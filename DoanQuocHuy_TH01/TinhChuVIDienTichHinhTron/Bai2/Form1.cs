using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double r = 0;
        double cv = 0;
        double dt = 0;
        private void btnTinh_Click(object sender, EventArgs e)
        {   try
            {
                r = Convert.ToDouble(txtR.Text);
            }
            catch
            {
                MessageBox.Show("Ban chua nhap gia tri cua R");
                return;
            }
            cv = 2 * 3.14 * r;
            dt = 3.14 * r * r;
            txtCV.Text = cv.ToString();
            txtDT.Text = dt.ToString();
        }

    private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
            {
                MessageBox.Show("Ban phai nhap so thuc");
                e.Handled = true;// chan ky tu vua nhap lai
            }
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            txtR.Text = "";
            txtCV.Text = "";
            txtDT.Text = "";
            txtR.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
