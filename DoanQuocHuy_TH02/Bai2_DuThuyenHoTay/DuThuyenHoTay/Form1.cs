using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuThuyenHoTay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtHT.Text = "";
            rdoCaNgay.Checked = false;
            rdoNuaNgay.Checked = false;
            cbChonDoUong.SelectedIndex = -1;
            cbSoLuong.SelectedIndex = -1;
            txtTien.Text = "";
            txtGiaDuThuyen.Text = "";
            tien = 0;
            txtHT.Focus();
        }



        private void rdoCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaDuThuyen.Text = "200";
        }

        private void rdoNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaDuThuyen.Text = "100";
        }
        double tien = 0;
        private void cbChonDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSoLuong.SelectedIndex = 0;
            if (cbChonDoUong.SelectedIndex == 0)
                tien = 0.5;
            if (cbChonDoUong.SelectedIndex == 1)
                tien = 0.8;
            if (cbChonDoUong.SelectedIndex == 2)
                tien = 1.0;
            tien *= Convert.ToDouble(cbSoLuong.SelectedItem);
            txtTien.Text = tien.ToString();
        }
        private void cbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChonDoUong.SelectedIndex == 0)
                tien = 0.5;
            if (cbChonDoUong.SelectedIndex == 1)
                tien = 0.8;
            if (cbChonDoUong.SelectedIndex == 2)
                tien = 1.0;
            tien *= Convert.ToDouble(cbSoLuong.SelectedItem);
            txtTien.Text = tien.ToString();
        }

        private void btnThemDs_Click(object sender, EventArgs e)
        {
            if(txtHT.Text=="")
            {
                MessageBox.Show("Ban chua nhap Ten Khach Hang");
                return;
            }
            else
            {
                if(!rdoCaNgay.Checked && !rdoNuaNgay.Checked)
                {
                    MessageBox.Show("Ban chua chon thoi gian thue du thuyen");
                }
                else
                {
                    if (cbChonDoUong.SelectedIndex == -1)
                    {
                        MessageBox.Show("Ban chua chon do uong");
                    }
                    else
                    {
                        if (cbSoLuong.SelectedIndex == -1)
                        {
                            MessageBox.Show("Ban chua chon so luong");
                        }
                        else
                        {
                            string item;
                            item = txtHT.Text + " | ";
                            if (rdoCaNgay.Checked)
                                item += "Ca Ngay | 200$ | Do Uong: " + txtTien.Text + " | Tong:  " + (tien + 200).ToString();
                            if (rdoNuaNgay.Checked)
                                item += "Nua Ngay | 100$ | Do Uong: " + txtTien.Text + " | Tong:  " + (tien + 100).ToString();
                            lstDS.Items.Add(item);
                        }
                    }
                }
            }
            
        }

        
    }
}
