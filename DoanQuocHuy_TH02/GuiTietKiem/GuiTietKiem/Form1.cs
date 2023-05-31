using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiTietKiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddComboBox()
        {
            cbThoiGianGui.Items.Add("1");
            cbThoiGianGui.Items.Add("3");
            cbThoiGianGui.Items.Add("6");
            cbThoiGianGui.Items.Add("12");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();
            //this.KeyPreview = true;
        }
        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ban phai nhap so nguyen!");
                e.Handled = true;
            }

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtHT.Text = "";
            txtDC.Text = "";
            txtSoTienGui.Text = "";
            dtpNgayGui.Text = "";
            cbThoiGianGui.Text = "";
            cbThoiGianGui.SelectedIndex = -1;
            radPhatLoc.Checked = false;
            radThuong.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong?",
                "Co hay Khong", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThemVao_Click(object sender, EventArgs e)
        {
            bool check = true;
            double TienLai = 0;
            if (txtMa.TextLength != 6)
            {
                MessageBox.Show("Nhap lai ma khach hang ( ma khach hang phai du 6 chu so) !!!");
                check = false;
            }
            else
            {
                if (txtHT.TextLength == 0 || txtDC.TextLength == 0)
                {
                    MessageBox.Show("Ho Ten Khach Hang hoac Dia Chi khong duoc de trong!");
                    check = false;
                }
                else
                {
                    if (txtSoTienGui.TextLength == 0)
                    {
                        MessageBox.Show("So Tien Gui Khong Duoc De Trong!");
                        check = false;
                    }
                    else
                        if(cbThoiGianGui.SelectedIndex==-1)
                        {
                            MessageBox.Show("Ban chua chon so thang gui");
                            check = false;
                        }
                        
                }
            }
            if (check)
            {
                if (radThuong.Checked == true)
                {
                    if (cbThoiGianGui.SelectedItem == "1")
                    {
                        TienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.06;

                    }
                    if (cbThoiGianGui.SelectedItem == "3")
                    {
                        TienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.07;

                    }
                    if (cbThoiGianGui.SelectedItem == "6")
                    {
                        TienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.08;

                    }
                    if (cbThoiGianGui.SelectedItem == "12")
                    {
                        TienLai = Convert.ToDouble(txtSoTienGui.Text) * 0.09;
                    }
                }
                else
                    if (radPhatLoc.Checked == true)
                {
                    if (cbThoiGianGui.SelectedItem == "1")
                    {
                        TienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.07;

                    }
                    if (cbThoiGianGui.SelectedItem == "3")
                    {
                        TienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.08;

                    }
                    if (cbThoiGianGui.SelectedItem == "6")
                    {
                        TienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.09;

                    }
                    if (cbThoiGianGui.SelectedItem == "12")
                    {
                        TienLai = Convert.ToInt32(txtSoTienGui.Text) * 0.1;

                    }
                }
                lstDanhSach.Items.Add(txtMa.Text + " | " + txtHT.Text + " | " +
                    txtDC.Text
                    + " | " + dtpNgayGui.Text + " | " + txtSoTienGui.Text + " | "
                    + cbThoiGianGui.Text + " tháng | " + TienLai);
                StaticData._NguoiGui.Add(new NguoiGui(Convert.ToInt32(txtMa.Text), txtHT.Text, txtDC.Text, Convert.ToInt32(txtSoTienGui.Text),
                    dtpNgayGui.Text, cbThoiGianGui.Text, TienLai));
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
