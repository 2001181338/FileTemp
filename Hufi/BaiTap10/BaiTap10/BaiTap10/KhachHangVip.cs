using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap10
{
    public class KhachHangVip : KhachHang, IThanhToanTamUng, ILaiXuatTraCham
    {
        public KhachHangVip(string maKhach, string tenKhach) : base(maKhach, tenKhach)
        {
        }
        public double tinhThanhToanTamUng(double tongTien)
        {
            return 0.4 * tongTien;
        }
        public double tinhLaiXuatTraCham(double tongTien)
        {
            return 0.02 * (tongTien - tinhThanhToanTamUng(tongTien));
        }

    }
}
