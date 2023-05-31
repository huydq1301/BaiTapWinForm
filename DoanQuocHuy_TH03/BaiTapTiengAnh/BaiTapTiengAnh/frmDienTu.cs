using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTiengAnh
{
    public partial class frmDienTu : Form
    {
        public frmDienTu()
        {
            for (int i = 0; i < StaticData.bt.Count; i++)
            {
                if (i == DataClick.check)
                {
                    BTDT = StaticData.bt[i];
                    break;
                }

            }
            InitializeComponent();
        }
        BaiTapDienTu BTDT = new BaiTapDienTu();
        private void frmDienTu_Load(object sender, EventArgs e)
        {
            
            rtfDeBai.Text = BTDT.Debai;
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            rtfDeBai.Text = BTDT.Dapan;
            btnOK.Enabled = false;
            txt1.ReadOnly=true;
            txt2.ReadOnly=true;
            txt3.ReadOnly = true;
            txt4.ReadOnly = true;
            txt5.ReadOnly = true;
            txt6.ReadOnly = true;
            txt7.ReadOnly = true;
            txt8.ReadOnly = true;
            txt9.ReadOnly = true;
            txt10.ReadOnly = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = 0;
            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "" || txt5.Text == "" ||
                txt6.Text == "" || txt7.Text == "" || txt8.Text == "" || txt9.Text == "" || txt10.Text == "")
            {
                MessageBox.Show("Ban chua nhap het dap an");
            }
            else
            {
                if (txt1.Text == BTDT.Dapantungcau[0])
                {
                    txt1.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt1.BackColor = Color.Red;
                }
                if (txt2.Text == BTDT.Dapantungcau[1])
                {
                    txt2.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt2.BackColor = Color.Red;
                }
                if (txt3.Text == BTDT.Dapantungcau[2])
                {
                    txt3.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt3.BackColor = Color.Red;
                }
                if (txt4.Text == BTDT.Dapantungcau[3])
                {
                    txt4.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt4.BackColor = Color.Red;
                }
                if (txt5.Text == BTDT.Dapantungcau[4])
                {
                    txt5.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt5.BackColor = Color.Red;
                }
                if (txt6.Text == BTDT.Dapantungcau[5])
                {
                    txt6.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt6.BackColor = Color.Red;
                }
                if (txt7.Text == BTDT.Dapantungcau[6])
                {
                    txt7.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt7.BackColor = Color.Red;
                }
                if (txt8.Text == BTDT.Dapantungcau[7])
                {
                    txt8.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt8.BackColor = Color.Red;
                }
                if (txt9.Text == BTDT.Dapantungcau[8])
                {
                    txt9.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt9.BackColor = Color.Red;
                }
                if (txt10.Text == BTDT.Dapantungcau[9])
                {
                    txt10.BackColor = Color.Green;
                    diem++;
                }
                else
                {
                    txt10.BackColor = Color.Red;
                }
                MessageBox.Show("Diem cua ban la: " + diem);

            }
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            rtfDeBai.Text = BTDT.Debai;
            txt1.Text = "";
            txt1.BackColor= Color.White;
            txt2.Text = "";
            txt2.BackColor = Color.White;
            txt3.Text = "";
            txt3.BackColor = Color.White;
            txt4.Text = "";
            txt4.BackColor = Color.White;
            txt5.Text = "";
            txt5.BackColor = Color.White;
            txt6.Text = "";
            txt6.BackColor = Color.White;
            txt7.Text = "";
            txt7.BackColor = Color.White;
            txt8.Text = "";
            txt8.BackColor = Color.White;
            txt9.Text = "";
            txt9.BackColor = Color.White;
            txt10.Text = "";
            txt10.BackColor = Color.White;
            btnOK.Enabled=true;
            txt1.ReadOnly = false;
            txt2.ReadOnly = false;
            txt3.ReadOnly = false;
            txt4.ReadOnly = false;
            txt5.ReadOnly = false;
            txt6.ReadOnly = false;
            txt7.ReadOnly = false;
            txt8.ReadOnly = false;
            txt9.ReadOnly = false;
            txt10.ReadOnly = false;
            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
