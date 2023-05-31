using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        DataConnect dtb = new DataConnect();
        string FileAnh;
        public bool CheckTrong()
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || cboChatLieu.SelectedIndex == -1 ||
                txtSoLuong.Text== ""|| txtDonGiaBan.Text == "" || txtDonGiaNhap.Text == "" || FileAnh == "")
                return true;
            else 
                return false;

        }
        public void ResetValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboChatLieu.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            FileAnh = "";
            picAnh.Image = null;
            txtMaHang.Focus();

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            lblUserName.Text="Xin Chào: " + staticdata.userName;
            if (staticdata.userName == "")
                this.Close();
            string sql = "select * from dbo.tblHang";
            dgvLIST.DataSource = dtb.DataReader(sql);
            dgvLIST.Columns[0].HeaderText = "Mã Hàng";
            dgvLIST.Columns[1].HeaderText = "Tên Hàng";
            dgvLIST.Columns[2].HeaderText = "Chất Liệu";
            dgvLIST.Columns[3].HeaderText = "Số Lượng";
            dgvLIST.Columns[4].HeaderText = "Đơn Giá Bán";
            dgvLIST.Columns[5].HeaderText = "Đơn Giá Nhập";
            dgvLIST.Columns[6].HeaderText = "Ảnh";
            dgvLIST.Columns[7].HeaderText = "Ghi Chú";
            ResetValue();
            btnThem.Enabled = true;
        }
        
        private void btnAnh_Click(object sender, EventArgs e)
        {
            string[] image;
            OpenFileDialog odlgOpen = new OpenFileDialog();
            odlgOpen.Filter = "JPEG Images|*.jpg|PNG Images|*.png|Bitmap Images|*.bmp|All Files|*.*";
            odlgOpen.FilterIndex = 1;
            odlgOpen.Title = "Select a image File to open";
            odlgOpen.InitialDirectory=Application.StartupPath;
            if (odlgOpen.ShowDialog() == DialogResult.OK) //khi nguoi dung click nut open;
            {
                picAnh.Image = Image.FromFile(odlgOpen.FileName);
                image = odlgOpen.FileName.ToString().Split('\\');
                FileAnh = image[image.Length-1];
            }
                
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Dữ liệu nhập vào phải là số");
                e.Handled = true;
            }
        }
     

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(CheckTrong())
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Dữ Liệu!");
                return;
            }
            if(float.Parse(txtDonGiaBan.Text) <= float.Parse(txtDonGiaNhap.Text))
            {
                MessageBox.Show("Đơn Giá Bán Phải Lớn Hơn Đơn Giá Nhập!");
                return;
            }
            string sql = "Select * From tblHang Where MaHang ='" + txtMaHang.Text +"'";
            DataTable dtMaHang = dtb.DataReader(sql);
            if (dtMaHang.Rows.Count > 0)
            {
                MessageBox.Show("Mã Hàng Đã Tồn Tại");
                txtMaHang.Focus();
                return;
            }
            //Insert vao CSDL
            string sqlínsert = "INSERT INTO tblHang(MaHang, TenHang, ChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu) VALUES(";
            sqlínsert += "N'" + txtMaHang.Text + "',N'" + txtTenHang.Text + "','" +
            cboChatLieu.Text + "','" +
            Convert.ToInt16(txtSoLuong.Text) + "',N'" + float.Parse(txtDonGiaNhap.Text) + "',N'" +
            float.Parse(txtDonGiaBan.Text) + "',N'" + FileAnh + "',N'" + txtGhiChu.Text + "')";
            dtb.DataChange(sqlínsert);
            //Cap nhat lai DataGrid
            string checksql = "select * from dbo.tblHang";
            dgvLIST.DataSource = dtb.DataReader(checksql);
            MessageBox.Show("Thêm Thành Công");
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                    {
                        string sql = "Delete From tblHang Where MaHang =N'" + txtMaHang.Text + "'";
                        ResetValue();
                        dtb.DataChange(sql);
                        //Cap nhat lai DataGrid
                        sql = "Select * from tblHang";
                        dgvLIST.DataSource = dtb.DataReader(sql);
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không được xóa ");
                    }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtDonGiaNhap.Text) > Convert.ToDouble(txtDonGiaBan.Text))
            {
                MessageBox.Show( "Đơn giá nhập phải < Đơn giá bán");
                return;
            }
            string editsql = "update tblHang set ";
            editsql += "TenHang = N'" + txtTenHang.Text + "', ";
            editsql += "ChatLieu = N'" + cboChatLieu.Text + "', ";
            editsql += "SoLuong = N'" + txtSoLuong.Text + "', ";
            editsql += "DonGiaNhap = N'" + txtDonGiaNhap.Text + "', ";
            editsql += "DonGiaBan = N'" + txtDonGiaBan.Text + "', ";
            editsql += "Anh = N'" + FileAnh + "', ";
            editsql += "GhiChu = N'" + txtGhiChu.Text + "' ";
            editsql += "where MaHang = N'" + txtMaHang.Text + "' ";
            dtb.DataChange(editsql);
            string checksql = "select * from dbo.tblHang";
            dgvLIST.DataSource = dtb.DataReader(checksql);
            ResetValue();
            btnThem.Enabled = true;
        }

        private void dgvLIST_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            //    
            txtMaHang.Text = dgvLIST.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvLIST.CurrentRow.Cells[1].Value.ToString();
            cboChatLieu.Text = dgvLIST.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvLIST.CurrentRow.Cells[3].Value.ToString();
            txtDonGiaNhap.Text = dgvLIST.CurrentRow.Cells[4].Value.ToString();
            txtDonGiaBan.Text = dgvLIST.CurrentRow.Cells[5].Value.ToString();
            FileAnh = dgvLIST.CurrentRow.Cells[6].Value.ToString();
            try
            {
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Images\\Products\\" + FileAnh);
            }
            catch
            {
                picAnh.Image = null;
            }
            txtGhiChu.Text = dgvLIST.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
