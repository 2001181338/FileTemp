using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaHamming
{
    public partial class Form1 : Form
    {
        int p4 = 0;
        int p3 = 0; 
        int p2 = 0;
        int p1 = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Group 10 - Hamming";
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != 49 && e.KeyChar != 48)
            {
                e.Handled = true;
            }
        }

        private void textChange(object sender, EventArgs e)
        {
            updateData();
        }

        private void checkBitError(object sender, EventArgs e)
        {
            updateData();
        }

        private void updateData()
        {
            //Caculate p
            p4 = (int.Parse(d5.Text) + int.Parse(d6.Text) + int.Parse(d7.Text) + int.Parse(d8.Text)) % 2;
            p3 = (int.Parse(d2.Text) + int.Parse(d3.Text) + int.Parse(d4.Text) + int.Parse(d8.Text)) % 2;
            p2 = (int.Parse(d1.Text) + int.Parse(d3.Text) + int.Parse(d4.Text) + int.Parse(d6.Text) + int.Parse(d7.Text)) % 2;
            p1 = (int.Parse(d1.Text) + int.Parse(d2.Text) + int.Parse(d4.Text) + int.Parse(d5.Text) + int.Parse(d7.Text)) % 2;

            //Update data p
            h1.Text = p1.ToString();
            h2.Text = p2.ToString();
            h4.Text = p3.ToString();
            h8.Text = p4.ToString();
            h3.Text = d1.Text;
            h5.Text = d2.Text;
            h6.Text = d3.Text;
            h7.Text = d4.Text;
            h9.Text = d5.Text;
            h10.Text = d6.Text;
            h11.Text = d7.Text;
            h12.Text = d8.Text;

            //Update codeword error
            c1.Text = p1.ToString();
            c2.Text = p2.ToString();
            c4.Text = p3.ToString();
            c8.Text = p4.ToString();
            c3.Text = d1.Text;
            c5.Text = d2.Text;
            c6.Text = d3.Text;
            c7.Text = d4.Text;
            c9.Text = d5.Text;
            c10.Text = d6.Text;
            c11.Text = d7.Text;
            c12.Text = d8.Text;

            //Update change codeword error when bitError checked
            var indexChecked = -1;
            for(int i = 1; i <= 12; i++)
            {
                //Update position bit error
                RadioButton positionRadio = this.Controls.Find("rd" + i, true).FirstOrDefault() as RadioButton;
                positionRadio.Checked = false;

                //UPdated show codeError
                RadioButton radio = this.Controls.Find("r" + i, true).FirstOrDefault() as RadioButton;
                if(radio != null && radio.Checked)
                {
                    Label codewordError = this.Controls.Find("c" + i, true).FirstOrDefault() as Label;
                    Label hammingCode = this.Controls.Find("h" + i, true).FirstOrDefault() as Label;
                    codewordError.Text = hammingCode.Text == "0" ? "1" : "0";
                    indexChecked = i;
                    positionRadio.Checked = true;
                }

             
            }

            //Caculate p
            var compareParity4 = (int.Parse(c9.Text) + int.Parse(c10.Text) + int.Parse(c11.Text) + int.Parse(c12.Text)) % 2;
            var compareParity3 = (int.Parse(c5.Text) + int.Parse(c6.Text) + int.Parse(c7.Text) + int.Parse(c12.Text)) % 2;
            var compareParity2 = (int.Parse(c3.Text) + int.Parse(c6.Text) + int.Parse(c7.Text) + int.Parse(c10.Text) + int.Parse(c11.Text)) % 2;
            var compareParity1 = (int.Parse(c3.Text) + int.Parse(c5.Text) + int.Parse(c7.Text) + int.Parse(c9.Text) + int.Parse(c11.Text)) % 2;
         
            //Update show parity of check bit
            parity4.Text = ((compareParity4 + p4) % 2).ToString();
            parity3.Text = ((compareParity3 + p3) % 2).ToString();
            parity2.Text = ((compareParity2 + p2) % 2).ToString();
            parity1.Text = ((compareParity1 + p1) % 2).ToString();

            if(indexChecked != -1)
            {
                if(indexChecked == 1)
                {
                    parity1.Text = "1";
                    compareParity1 = p1 == 0 ? 1 : 0;
                }
                else if(indexChecked == 2)
                {
                    parity2.Text = "1";
                    compareParity2 = p2 == 0 ? 1 : 0;
                }
                else if (indexChecked == 4)
                {
                    parity3.Text = "1";
                    compareParity3 = p3 == 0 ? 1 : 0;
                }
                else if (indexChecked == 8)
                {
                    parity4.Text = "1";
                    compareParity4 = p4 == 0 ? 1 : 0;
                }

            }

        }
    }


}
