using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap10
{
    public class KhachHangThanThiet : KhachHang, IThanhToanTamUng, ILaiXuatTraCham
    {
        public KhachHangThanThiet(string maKhach, string tenKhach) : base(maKhach, tenKhach)
        {
        }
        public double tinhThanhToanTamUng(double tongTien)
        {
            return 0.6 * tongTien;
        }
        public double tinhLaiXuatTraCham(double tongTien)
        {
            return 0.03 * (tongTien - tinhThanhToanTamUng(tongTien));
        }
    }
}
