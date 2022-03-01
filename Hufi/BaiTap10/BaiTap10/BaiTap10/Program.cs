using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace BaiTap10
{
    class Program
    {
        static void Main(string[] args)
        {
            var danhSachHoaDon = new DanhSachHoaDon();
            danhSachHoaDon.nhapFileXml();
            //2. Xuat hoa don
            Console.WriteLine("Cau 2: Xuat thong tin danh sach hoa don: ");
            danhSachHoaDon.xuatHoaDon();

            //3. Xuat hoa don khach vang lai
            Console.WriteLine("\nCau 3: Xuat thong hoa don khach vang lai: ");
            danhSachHoaDon.xuatHoaDonKhachVangLai();

            //4. Xuat tong thanh tien cua cac hoa don
            Console.WriteLine("\nCau 4: Xuat tong thanh tien cua cac hoa don: ");
            danhSachHoaDon.xuatTongThanhTienHoaDon();

            //5. Xuat hoa don co tong tien cao nhat
            Console.WriteLine("\nCau 5: Xuat hoa don co tong tien cao nhat: ");
            danhSachHoaDon.xuatHoaDonCoTongTienCaoNhat();

            //6. Dem so hoa don cua khach Vip, than thiet
            Console.WriteLine("\nCau 6: So hoa don cua khach Vip: {0}", danhSachHoaDon.soLuongHoaDonKhachVip());
            Console.WriteLine("\nCau 6: So hoa don cua khach Than thiet: {0}", danhSachHoaDon.soLuongHoadonKhachThanThiet());

            //7. Tinh tong thanh toan tam ung cua khach Nguyen Long
            Console.WriteLine("\nCau 7: Tong thanh toan tam ung cua khach Nguyen Long: {0}", danhSachHoaDon.tinhTongTienTamUngCuakhach("Nguyen Long"));

            //8. Sap xep hoa don tang dan theo tong tien, neu tong tien bang thi sap xep giam theo so ma so
            Console.WriteLine("\nCau 8: Sap xep hoa don:");
            danhSachHoaDon.sapXepHoaDonTangTongTienGiamMaSo();
            danhSachHoaDon.xuatHoaDon();
        }
    }
}
