using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BaiTap10
{
    public class DanhSachHoaDon
    {
        public List<HoaDon> hoaDons = new List<HoaDon>();
        public List<KhachHangVip> listKhachVip = new List<KhachHangVip>();
        public List<KhachHangThanThiet> listThanThiet = new List<KhachHangThanThiet>();
        public List<KhachVangLai> listVangLai = new List<KhachVangLai>();
        public void nhapFileXml()
        {
            XmlDocument read = new XmlDocument();
            read.Load("DSHD.xml");
            XmlNodeList nodeList = read.SelectNodes("DSHD/HoaDon");
            foreach (XmlNode node in nodeList)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaSo = node["MS"].InnerText;
                hoaDon.NgayLap = DateTime.Parse(node["NgayLap"].InnerText);
                hoaDon.SoLuong = int.Parse(node["SoLuong"].InnerText);

                //Doc node Hang
                XmlNodeList nodeHangs = node["Hang"].ChildNodes;
                MatHangXangDau matHangXangDau = new MatHangXangDau();
                foreach (XmlNode nodeHang in nodeHangs)
                {
                    if (nodeHang.Name == "MH")
                    {
                        matHangXangDau.MaHang = nodeHang.InnerText;
                    }
                    else if (nodeHang.Name == "TenHang")
                    {
                        matHangXangDau.TenHang = nodeHang.InnerText;
                    }
                    else
                    {
                        matHangXangDau.DonGia = Double.Parse(nodeHang.InnerText);
                    }
                }

                //Doc node Khach
                string maKhach = "";
                string hoTen = "";
                if (node["Khach"] != null)
                {
                    XmlNodeList nodeKhachs = node["Khach"].ChildNodes;
                    foreach (XmlNode nodeKhach in nodeKhachs)
                    {
                        if (nodeKhach.Name == "MaKhach")
                        {
                            maKhach = nodeKhach.InnerText;
                        }
                        else
                        {
                            hoTen = nodeKhach.InnerText;
                        }
                    }
                }

                int loai = int.Parse(node["Loai"].InnerText);
                hoaDon.TenKhach = hoTen;
                hoaDon.MatHangXangDau = matHangXangDau;
                hoaDon.LoaiKhach = loai;
                hoaDons.Add(hoaDon);
                if (loai == 1)
                {
                    var kh = new KhachHangVip(maKhach, hoTen);
                    listKhachVip.Add(kh);
                }
                else if (loai == 2)
                {
                    var kh = new KhachHangThanThiet(maKhach, hoTen);
                    listThanThiet.Add(kh);
                }
                else
                {
                    var kh = new KhachVangLai(maKhach, hoTen);
                    listVangLai.Add(kh);
                }
            }


        }
        
        public void xuatHoaDon()
        {
            hoaDons.ForEach(x => x.xuatHoaDon());
        }

        public void xuatHoaDonKhachVangLai()
        {
            var hoaDonKhachVangLai = hoaDons.Where(x => x.LoaiKhach != 1 && x.LoaiKhach != 2).ToList();
            hoaDonKhachVangLai.ForEach(x => x.xuatHoaDon());
        }
        
        public void xuatTongThanhTienHoaDon()
        {
            hoaDons.ForEach(x => x.xuatTongThanhTien());
        }

        public void xuatHoaDonCoTongTienCaoNhat()
        {
            var tongTienMax = hoaDons.Max(x => x.tongThanhTien());
            var hoaDonMax = hoaDons.FirstOrDefault(x => x.tongThanhTien() == tongTienMax);
            hoaDonMax.xuatHoaDon();
        }

        public int soLuongHoaDonKhachVip()
        {
            return hoaDons.Where(x => x.LoaiKhach == 1).Count();
        }
        public int soLuongHoadonKhachThanThiet()
        {
            return hoaDons.Where(x => x.LoaiKhach == 2).Count();

        }

        public double tinhTongTienTamUngCuakhach(string tenKhach)
        {
            var hoaDonNguyenLong = hoaDons.Where(x => x.TenKhach == tenKhach).ToList();
            double tongTien = 0;
            foreach (var hoaDon in hoaDonNguyenLong)
            {
                if (hoaDon.LoaiKhach == 1)
                {
                    var nguyenLong = listKhachVip.FirstOrDefault(x => x.TenKhach == tenKhach);
                    tongTien += nguyenLong.tinhThanhToanTamUng(hoaDon.tongThanhTien());
                }

                if (hoaDon.LoaiKhach == 2)
                {
                    var nguyenLong = listThanThiet.FirstOrDefault(x => x.TenKhach == tenKhach);
                    tongTien += nguyenLong.tinhThanhToanTamUng(hoaDon.tongThanhTien());
                }
            }
            return tongTien;
        }

        public void sapXepHoaDonTangTongTienGiamMaSo()
        {
            hoaDons = hoaDons.OrderBy(x => x.tongThanhTien()).ThenBy(y => y.MaSo).ToList();
        }
    }   
}
