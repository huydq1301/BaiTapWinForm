namespace GuiTietKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbThoiGianGui = new System.Windows.Forms.ComboBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVao = new System.Windows.Forms.Button();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDC = new System.Windows.Forms.Label();
            this.labelHT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radPhatLoc = new System.Windows.Forms.RadioButton();
            this.radThuong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpNgayGui = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayGui);
            this.groupBox1.Controls.Add(this.cbThoiGianGui);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVao);
            this.groupBox1.Controls.Add(this.txtSoTienGui);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelDC);
            this.groupBox1.Controls.Add(this.labelHT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // cbThoiGianGui
            // 
            this.cbThoiGianGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiGianGui.FormattingEnabled = true;
            this.cbThoiGianGui.Location = new System.Drawing.Point(121, 246);
            this.cbThoiGianGui.Name = "cbThoiGianGui";
            this.cbThoiGianGui.Size = new System.Drawing.Size(50, 24);
            this.cbThoiGianGui.TabIndex = 15;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(144, 380);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(91, 30);
            this.btnThemMoi.TabIndex = 14;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVao
            // 
            this.btnThemVao.Location = new System.Drawing.Point(12, 380);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(101, 30);
            this.btnThemVao.TabIndex = 13;
            this.btnThemVao.Text = "&Thêm vào";
            this.btnThemVao.UseVisualStyleBackColor = true;
            this.btnThemVao.Click += new System.EventHandler(this.btnThemVao_Click);
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(104, 163);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(151, 22);
            this.txtSoTienGui.TabIndex = 10;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(104, 122);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(151, 22);
            this.txtDC.TabIndex = 9;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(104, 82);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(151, 22);
            this.txtHT.TabIndex = 8;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(104, 37);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(151, 22);
            this.txtMa.TabIndex = 7;
            this.txtMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMa_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thời gian gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày gửi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số tiền gửi";
            // 
            // labelDC
            // 
            this.labelDC.AutoSize = true;
            this.labelDC.Location = new System.Drawing.Point(3, 122);
            this.labelDC.Name = "labelDC";
            this.labelDC.Size = new System.Drawing.Size(47, 16);
            this.labelDC.TabIndex = 3;
            this.labelDC.Text = "Địa chỉ";
            // 
            // labelHT
            // 
            this.labelHT.AutoSize = true;
            this.labelHT.Location = new System.Drawing.Point(3, 82);
            this.labelHT.Name = "labelHT";
            this.labelHT.Size = new System.Drawing.Size(73, 16);
            this.labelHT.TabIndex = 2;
            this.labelHT.Text = "Họ Tên KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radPhatLoc);
            this.groupBox3.Controls.Add(this.radThuong);
            this.groupBox3.Location = new System.Drawing.Point(6, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 60);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại tiết kiệm";
            // 
            // radPhatLoc
            // 
            this.radPhatLoc.AutoSize = true;
            this.radPhatLoc.Location = new System.Drawing.Point(115, 21);
            this.radPhatLoc.Name = "radPhatLoc";
            this.radPhatLoc.Size = new System.Drawing.Size(76, 20);
            this.radPhatLoc.TabIndex = 1;
            this.radPhatLoc.TabStop = true;
            this.radPhatLoc.Text = "Phát lộc";
            this.radPhatLoc.UseVisualStyleBackColor = true;
            // 
            // radThuong
            // 
            this.radThuong.AutoSize = true;
            this.radThuong.Location = new System.Drawing.Point(6, 21);
            this.radThuong.Name = "radThuong";
            this.radThuong.Size = new System.Drawing.Size(74, 20);
            this.radThuong.TabIndex = 0;
            this.radThuong.TabStop = true;
            this.radThuong.Text = "Thường";
            this.radThuong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 361);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(21, 37);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(489, 324);
            this.lstDanhSach.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(460, 392);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 36);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(674, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 35);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGui.Location = new System.Drawing.Point(104, 205);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.Size = new System.Drawing.Size(151, 22);
            this.dtpNgayGui.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVao;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDC;
        private System.Windows.Forms.Label labelHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbThoiGianGui;
        private System.Windows.Forms.RadioButton radPhatLoc;
        private System.Windows.Forms.RadioButton radThuong;
        private System.Windows.Forms.DateTimePicker dtpNgayGui;
    }
}

