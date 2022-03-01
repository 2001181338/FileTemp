using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap10
{
    public class HoaDon
    {
        private string maSo;
        private DateTime ngayLap;
        private int soLuong;
        private int loaiKhach;
        private string tenKhach;
        private MatHangXangDau matHangXangDau;
        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string TenKhach
        {
            get { return tenKhach; }
            set { tenKhach = value; }
        }
        public int LoaiKhach
        {
            get { return loaiKhach; }
            set { loaiKhach = value; }
        }
        public MatHangXangDau MatHangXangDau
        {
            get { return matHangXangDau; }
            set { matHangXangDau = value; }
        }

        public HoaDon() { }

        public HoaDon(string maSo, DateTime ngayLap, int soLuong, string tenKhach, int loaiKhach, MatHangXangDau matHangXangDau)
        {
            this.maSo = maSo;
            this.ngayLap = ngayLap;
            this.soLuong = soLuong;
            this.tenKhach = tenKhach;
            this.matHangXangDau = matHangXangDau;
            this.loaiKhach = loaiKhach;
        }

        public void xuatHoaDon()
        {
            Console.WriteLine("MaSo: {0}, KhachHang: {1}, LoaiKhach: {2}, NgayLap: {3}, MaHang: {4}, TenHang: {5}, Gia: {6}, SoLuong: {7}",
                this.maSo, this.tenKhach, this.loaiKhach, this.ngayLap, this.matHangXangDau.MaHang, this.matHangXangDau.TenHang, this.matHangXangDau.DonGia, this.soLuong);
        }
        public double tongThanhTien()
        {
            return tinhThanhTien() - tinhTienKhuyenMai();
        }

        public double tinhThanhTien()
        {
            return this.matHangXangDau.DonGia * this.soLuong;
        }

        public double tinhTienKhuyenMai()
        {
            double tienKhuyenMai = 0;
            //Khach VIP
            if (this.loaiKhach == 1)
            {
                if (this.soLuong > 50)
                {
                    tienKhuyenMai = tinhThanhTien() * 0.05;
                }
                else if (this.soLuong <= 50 && tinhThanhTien() >= 600000)
                {
                    tienKhuyenMai = tinhThanhTien() * 0.04;
                }
                else if (this.soLuong >= 10)
                {
                    tienKhuyenMai = tinhThanhTien() * 0.01;
                }
                else
                {
                    tienKhuyenMai = 0;
                }
            }
            //Khach Than Thiet
            else if (this.loaiKhach == 2)
            {
                if (this.soLuong > 60)
                {
                    tienKhuyenMai = tinhThanhTien() * 0.04;
                }
                else if (this.soLuong <= 50 && tinhThanhTien() >= 800000)
                {
                    tienKhuyenMai = tinhThanhTien() * 0.03;
                }
                else
                {
                    tienKhuyenMai = 0;
                }
            }
            //Khach Vang Lai
            else
            {
                if (tinhThanhTien() > 1000000)
                {
                    tienKhuyenMai = tinhThanhTien() * 0.03;
                }
                else
                {
                    tienKhuyenMai = 0;
                }
            }
           

            return tienKhuyenMai;
        }
        
        public void xuatTongThanhTien()
        {
            Console.WriteLine("MaSo: {0}, TongTien: {1}", this.maSo, tongThanhTien());
        }

    }
}
