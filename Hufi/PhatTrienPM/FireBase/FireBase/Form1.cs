using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBase
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tRYF3hnWNagcwbecl6dAjdZp6Pt1Nc044ZsYNDeu",
            BasePath = "https://thuchanhfirebase-ptpm-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if(client != null)
            {
                LoadDataGrid();
                MessageBox.Show("Connected");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoten.Text;

            if(string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Khong duoc de trong");
                return;
            }

            //Check SV is existed?
            var result = client.Get("Sinhvien/" + maSV);
            var sinhVienDB = result.ResultAs<SinhVien>();
            if (sinhVienDB != null)
            {
                MessageBox.Show("Ma SV da ton tai");
                return;
            }

            var sv = new SinhVien()
            {
                MaSV = maSV,
                HoTen = hoTen
            };


            client.Set("Sinhvien/" + maSV, sv);
            MessageBox.Show("Them thanh cong");

            txtMaSV.Clear();
            txtHoten.Clear();
            LoadDataGrid();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("MaSV khong duoc de trong");
                return;
            }

            //Check SV is existed?
            var result = client.Get("Sinhvien/" + maSV);
            var sinhVienDB = result.ResultAs<SinhVien>();
            if (sinhVienDB == null)
            {
                MessageBox.Show("Ma SV khong ton tai");
                return;
            }

            txtHoten.Text = sinhVienDB.HoTen;
            MessageBox.Show("Tim thay");
        }

        private void LoadDataGrid()
        {

            var result = client.Get("Sinhvien");
            var listSV = result.ResultAs<List<SinhVien>>();

            listSV = listSV.Where(x => x != null).ToList();
            dataGridView1.DataSource = listSV;
        }
    }
}
