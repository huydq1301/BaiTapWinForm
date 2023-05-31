﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Net.NetworkInformation;

namespace BanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Khai báo và khởi tạo biến toàn cục trong class frmMatHang sử dụng class DataBaseProcess
        DataConnect dtb = new DataConnect();
        //Phương thức ẩn hiện các control trong groupBox Chi tiết
        private void HienChiTiet(bool hien)
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            dtpNgayHH.Enabled = hien;
            dtpNgaySX.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }
        private void XoaTrangChiTiet()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dtpNgaySX.Value = DateTime.Today;
            dtpNgayHH.Value = DateTime.Today;
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
        }
        //Sự kiện load_Form
        private void Form1_Load(object sender, EventArgs e)
        {
            //Load dữ liệu lên DataGridView
            string sql = "select * from dbo.tblMatHang";
            dgvDS.DataSource = dtb.DataReader(sql);
            //Ẩn nút Sửa,xóa 
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Ẩn groupBox chi tiết
            HienChiTiet(false);
        }
        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sua
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                txtMaSP.Text = dgvDS.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvDS.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySX.Value = (DateTime)dgvDS.CurrentRow.Cells[2].Value;
                dtpNgayHH.Value = (DateTime)dgvDS.CurrentRow.Cells[3].Value;
                txtDonVi.Text = dgvDS.CurrentRow.Cells[4].Value.ToString();
                txtDonGia.Text = dgvDS.CurrentRow.Cells[5].Value.ToString();
                txtGhiChu.Text = dgvDS.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Tìm Kiếm Sản Phẩm";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (txtTKMaSP.Text == "" && txtTKTenSP.Text == "")
            {
                MessageBox.Show("Bạn chưa thông tin cần tìm kiếm");
            }
            else
            {
                string sql = "SELECT * FROM tblMatHang where";
                if (txtTKMaSP.Text != "")
                {
                    //Tim theo MaSP khac rong
                    sql += " MaSP = '" + txtTKMaSP.Text + "'";
                }
                if (txtTKTenSP.Text != "")
                {
                    //tim theo ten sp
                    sql += " TenSP = N'" + txtTKTenSP.Text + "'";
                }
                //Load dữ liệu tìm được lên dataGridView
                dgvDS.DataSource = dtb.DataReader(sql);
                if (dgvDS.RowCount <= 1)
                    MessageBox.Show("Khong ton tai san pham nhu tim kiem");
            }
        }

        private void txtTKMaSP_MouseDown(object sender, MouseEventArgs e)
        {
            txtTKTenSP.Text = "";
        }

        private void txtTKTenSP_TextChanged(object sender, EventArgs e)
        {
            txtTKMaSP.Text = "";
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM MẶT HÀNG";
            //Xoa trang GroupBox chi tiết sản phẩm
            XoaTrangChiTiet();
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cập nhật tiêu đề
            lblTieuDe.Text = "CẬP NHẬT MẶT HÀNG";
            //Ẩn hai nút Thêm và Xóa
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện gropbox chi tiết
            HienChiTiet(true);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Bật Message Box cảnh báo người sử dụng
            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " +
           txtMaSP.Text + " không ? Nếu có ấn nút Lưu, không thì ấn nút Hủy",
           "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblTieuDe.Text = "XÓA MẶT HÀNG";
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                //Hiện gropbox chi tiết
                HienChiTiet(true);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
            //xoa trang chi tiết
            XoaTrangChiTiet();
            //Cam nhap vào groupBox chi tiết
            HienChiTiet(false);
            errChiTiet.Clear();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
            string sql = "";
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra tên sản phầm có bị để trống không
            if (txtTenSP.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenSP, "Bạn không để trống tên sản phẩm!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra ngày sản xuất, lỗi nếu người sử dụng nhập vào ngày 
            //sản xuất lớn hơn ngày hiện tại
            if (dtpNgaySX.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNgaySX, "Ngày sản xuất không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra ngày hết hạn xem có lớn hơn ngày sản xuất không
            if (dtpNgayHH.Value < dtpNgaySX.Value)
            {
                errChiTiet.SetError(dtpNgayHH, "Ngay hết hạn nhỏ hơn ngày sản xuất!"); 
            return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra đơn vị xem có để trống không 
            if (txtDonVi.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDonVi, "Bạn không để trống đơn vi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra đơn giá 
            if (txtDonGia.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDonGia, "Bạn không để trống đơn giá!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Nếu nút Thêm enable thì thực hiện thêm mới 
            //Dùng ký tự N' trước mỗi giá trị kiểu text để insert giá trị có dấu 
            //tiếng việt vào CSDL được đúng
            if (btnThem.Enabled == true)
            { //Kiểm tra xem ô nhập MaSP có bị trống không if
                if (txtMaSP.Text.Trim() == "")
                {
                    errChiTiet.SetError(txtMaSP, "Bạn không để trống mã sản phẩm trường này!"); 
                return;
                }
                else
                { //Kiểm tra xem mã sản phẩm đã tồn tại chưa đẻ tránh việc insert mới bị lỗi
                    sql = "Select * From tblMatHang Where MaSP ='" + txtMaSP.Text +
                    "'";
                    DataTable dtSP = dtb.DataReader(sql);
                    if (dtSP.Rows.Count > 0)
                    {
                        errChiTiet.SetError(txtMaSP, "Mã sản phẩm trùng trong cơ sở dữ liệu");
                     return;
                    }
                    errChiTiet.Clear();
                }
                //Insert vao CSDL
                sql = "INSERT INTO tblMatHang(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu) VALUES(";
                sql += "N'" + txtMaSP.Text + "',N'" + txtTenSP.Text + "','" +
                dtpNgaySX.Value.Date + "','" +
                dtpNgayHH.Value.Date + "',N'" + txtDonVi.Text + "',N'" +
                txtDonGia.Text + "',N'" + txtGhiChu.Text + "')";
            }
            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btnSua.Enabled == true)
            {
                sql = "Update tblMatHang SET ";
                sql += "TenSP = N'" + txtTenSP.Text + "',";
                sql += "NgaySX = '" + dtpNgaySX.Value.Date + "',";
                sql += "NgayHH = '" + dtpNgayHH.Value.Date + "',";
                sql += "DonVi = N'" + txtDonVi.Text + "',";
                sql += "DonGia = '" + txtDonGia.Text + "',";
                sql += "GhiChu = N'" + txtGhiChu.Text + "' ";
                sql += "Where MaSP = N'" + txtMaSP.Text + "'";
            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnXoa.Enabled == true)
            {
                sql = "Delete From tblMatHang Where MaSP =N'" + txtMaSP.Text + "'";
            }
            dtb.DataChange(sql);
            //Cap nhat lai DataGrid
            sql = "Select * from tblMatHang";
            dgvDS.DataSource = dtb.DataReader(sql);
            //Ẩn hiện các nút phù hợp chức năng
            HienChiTiet(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtTKTenSP_MouseDown(object sender, MouseEventArgs e)
        {
            txtTKMaSP.Text = "";
        }
    }
}
