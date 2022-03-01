using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap10
{
    public class MatHangXangDau
    {
        private string maHang;
        private string tenHang;
        private double donGia;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public MatHangXangDau() { }
        public MatHangXangDau(string maHang, string tenHang, double donGia)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.donGia = donGia;
        }
    }
}
