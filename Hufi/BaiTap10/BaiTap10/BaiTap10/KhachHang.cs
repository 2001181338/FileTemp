using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap10
{
    public class KhachHang
    {
        private string maKhach;
        private string tenKhach;
        public string MaKhach
        {
            get { return maKhach; }
            set { maKhach = value; }
        }
        public string TenKhach
        {
            get { return tenKhach; }
            set { tenKhach = value; }
        }
        public KhachHang(string maKhach, string tenKhach)
        {
            this.maKhach = maKhach;
            this.tenKhach = tenKhach;
        }
    }
}
