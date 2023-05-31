using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            try
            {
                x1 = Convert.ToDouble(txtX1.Text);
                x2 = Convert.ToDouble(txtX2.Text);
                y1 = Convert.ToDouble(txtY1.Text);
                y2 = Convert.ToDouble(txtY2.Text);
            }
            catch
            {
                MessageBox.Show("Ban chua nhap gia tri");
                return;
            }
            double hsg = 1.00* (y2 - y1) / (x2 - x1);
            double kc = 1.00*Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1, 2));
            txtHSG.Text = hsg.ToString();
            txtKC.Text = kc.ToString();
        }


        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
            {
                MessageBox.Show("Ban phai nhap so thuc");
                e.Handled = true;// chan ky tu vua nhap lai
            }
        }
    }
}
