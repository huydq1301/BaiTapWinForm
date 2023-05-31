using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_DIemMonHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TongTC = 0;
        Double DiemTheoTC;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();

        }
        private void cbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenMonHoc.SelectedIndex == 0 || cbTenMonHoc.SelectedIndex == 3)
                txtSoTinChi.Text = "2";
            else
                txtSoTinChi.Text = "3";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbTenMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Ban chua chon mon hoc");
                return;
            }
            double diem;
            try
            {
                diem = Convert.ToDouble(txtDiem.Text);
            }
            catch
            {
                MessageBox.Show("Ban chua nhap diem");
                return;
            }
            if(diem<0 || diem>=10)
            {
                MessageBox.Show("Diem phai la so thuc tu 0->10");
                return;
            }
            TongTC += Convert.ToInt16(txtSoTinChi.Text);
            DiemTheoTC += diem*Convert.ToInt16(txtSoTinChi.Text);
            lsDs.Items.Add(cbTenMonHoc.Text + " - " + txtSoTinChi.Text + " - " + diem.ToString());
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Diem phai la dang chu so");
            }

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(lsDs.Items.Count == 0)
            {
                MessageBox.Show("Danh Sach Rong. Ban can nhap mon hoc");
                return;
            }
            else
            {
                txtTongDiem.Text = DiemTheoTC.ToString();
                txtTongTinChi.Text=TongTC.ToString();
                txtDiemTB.Text = Math.Round(DiemTheoTC/TongTC,1).ToString();
            }
        }
    }
}
