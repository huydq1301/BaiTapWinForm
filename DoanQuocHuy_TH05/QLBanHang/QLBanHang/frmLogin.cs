using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DataConnect dtb = new DataConnect();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUser.Text == "")
            {
                MessageBox.Show("Chưa nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Chưa nhập Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //string checkuser = "aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆf" +
            //"FgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪ" +
            //"ửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ";
            //for(int i=0; i<txtUser.Text.Length;i++)
            //{
            //    for(int j=0;j<checkuser.Length;j++)
            //        if(txtUser.Text[i] == checkuser[i])
            //        {
            //            MessageBox.Show("Tài Khoản Không Đúng Định Dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            break;
            //            return;
            //        }
            //}
            string sql = "select * from tblUser where UserName = N'" + txtUser.Text + "' and PassWord = N'" + txtPass.Text + "'";
            SqlDataReader dt = dtb.ReaderLogin(sql);
            if (!dt.HasRows)
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!dt.Read())
            {
                MessageBox.Show("Có Lỗi Xảy Ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string user = dt[0].ToString();
            string pass = dt[1].ToString();
            if (txtUser.Text != user)
            {
                MessageBox.Show("Không Tồn Tại Tài Khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPass.Text != pass)
            {
                MessageBox.Show("Mật Khẩu Sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đăng Nhập Thành Công!", "Thông báo", MessageBoxButtons.OK);
            staticdata.userName = txtUser.Text;
            this.Close();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
