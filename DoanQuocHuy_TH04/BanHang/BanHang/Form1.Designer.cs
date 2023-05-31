namespace BanHang
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grnMenu = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.errChiTiet = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTKTenSP = new System.Windows.Forms.TextBox();
            this.txtTKMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.grbKQ = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.grnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.grbKQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTieuDe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(317, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(276, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Quản Lý Sản Phẩm";
            // 
            // grnMenu
            // 
            this.grnMenu.Controls.Add(this.btnThoat);
            this.grnMenu.Controls.Add(this.btnXoa);
            this.grnMenu.Controls.Add(this.btnSua);
            this.grnMenu.Controls.Add(this.btnThem);
            this.grnMenu.Controls.Add(this.btnTimKiem);
            this.grnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grnMenu.Location = new System.Drawing.Point(0, 526);
            this.grnMenu.Name = "grnMenu";
            this.grnMenu.Size = new System.Drawing.Size(1012, 67);
            this.grnMenu.TabIndex = 1;
            this.grnMenu.TabStop = false;
            this.grnMenu.Text = " ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(756, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(586, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(422, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(251, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "T&hêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(70, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 34);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // errChiTiet
            // 
            this.errChiTiet.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên SP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày SX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày HH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn vị:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đơn giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ghi chú:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(107, 33);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(159, 22);
            this.txtMaSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(107, 76);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(159, 22);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(107, 195);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(159, 22);
            this.txtDonVi.TabIndex = 4;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(107, 238);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(159, 22);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(107, 281);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(159, 22);
            this.txtGhiChu.TabIndex = 6;
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySX.Location = new System.Drawing.Point(107, 114);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(159, 22);
            this.dtpNgaySX.TabIndex = 2;
            // 
            // dtpNgayHH
            // 
            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHH.Location = new System.Drawing.Point(107, 154);
            this.dtpNgayHH.Name = "dtpNgayHH";
            this.dtpNgayHH.Size = new System.Drawing.Size(159, 22);
            this.dtpNgayHH.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(21, 322);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 34);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(156, 322);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 34);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.btnHuy);
            this.grbChiTiet.Controls.Add(this.btnLuu);
            this.grbChiTiet.Controls.Add(this.dtpNgayHH);
            this.grbChiTiet.Controls.Add(this.dtpNgaySX);
            this.grbChiTiet.Controls.Add(this.txtGhiChu);
            this.grbChiTiet.Controls.Add(this.txtDonGia);
            this.grbChiTiet.Controls.Add(this.txtDonVi);
            this.grbChiTiet.Controls.Add(this.txtTenSP);
            this.grbChiTiet.Controls.Add(this.txtMaSP);
            this.grbChiTiet.Controls.Add(this.label9);
            this.grbChiTiet.Controls.Add(this.label8);
            this.grbChiTiet.Controls.Add(this.label7);
            this.grbChiTiet.Controls.Add(this.label6);
            this.grbChiTiet.Controls.Add(this.label5);
            this.grbChiTiet.Controls.Add(this.label4);
            this.grbChiTiet.Controls.Add(this.label3);
            this.grbChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbChiTiet.Location = new System.Drawing.Point(724, 58);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(288, 468);
            this.grbChiTiet.TabIndex = 2;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi tiết";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(711, 58);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(13, 468);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.txtTKTenSP);
            this.grbTimKiem.Controls.Add(this.txtTKMaSP);
            this.grbTimKiem.Controls.Add(this.label2);
            this.grbTimKiem.Controls.Add(this.label1);
            this.grbTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTimKiem.Location = new System.Drawing.Point(0, 58);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(711, 52);
            this.grbTimKiem.TabIndex = 4;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTKTenSP
            // 
            this.txtTKTenSP.Location = new System.Drawing.Point(397, 24);
            this.txtTKTenSP.Name = "txtTKTenSP";
            this.txtTKTenSP.Size = new System.Drawing.Size(159, 22);
            this.txtTKTenSP.TabIndex = 1;
            this.txtTKTenSP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTKTenSP_MouseDown);
            // 
            // txtTKMaSP
            // 
            this.txtTKMaSP.Location = new System.Drawing.Point(90, 26);
            this.txtTKMaSP.Name = "txtTKMaSP";
            this.txtTKMaSP.Size = new System.Drawing.Size(159, 22);
            this.txtTKMaSP.TabIndex = 0;
            this.txtTKMaSP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTKMaSP_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 110);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(711, 10);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // grbKQ
            // 
            this.grbKQ.Controls.Add(this.dgvDS);
            this.grbKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbKQ.Location = new System.Drawing.Point(0, 120);
            this.grbKQ.Name = "grbKQ";
            this.grbKQ.Size = new System.Drawing.Size(711, 406);
            this.grbKQ.TabIndex = 6;
            this.grbKQ.TabStop = false;
            this.grbKQ.Text = "Kết Quả";
            // 
            // dgvDS
            // 
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(3, 18);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.RowTemplate.Height = 24;
            this.dgvDS.Size = new System.Drawing.Size(705, 385);
            this.dgvDS.TabIndex = 0;
            this.dgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 593);
            this.Controls.Add(this.grbKQ);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.grnMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errChiTiet)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbKQ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grnMenu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.ErrorProvider errChiTiet;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbKQ;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtTKTenSP;
        private System.Windows.Forms.TextBox txtTKMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

