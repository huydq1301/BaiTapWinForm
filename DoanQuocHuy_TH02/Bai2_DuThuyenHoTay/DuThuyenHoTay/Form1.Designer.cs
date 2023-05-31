namespace DuThuyenHoTay
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
            this.txtTien = new System.Windows.Forms.TextBox();
            this.cbSoLuong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbChonDoUong = new System.Windows.Forms.ComboBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemDs = new System.Windows.Forms.Button();
            this.rdoNuaNgay = new System.Windows.Forms.RadioButton();
            this.rdoCaNgay = new System.Windows.Forms.RadioButton();
            this.txtGiaDuThuyen = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstDS = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.cbSoLuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbChonDoUong);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemDs);
            this.groupBox1.Controls.Add(this.rdoNuaNgay);
            this.groupBox1.Controls.Add(this.rdoCaNgay);
            this.groupBox1.Controls.Add(this.txtGiaDuThuyen);
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 450);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Khách Hàng Đặt Tour";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(272, 279);
            this.txtTien.Multiline = true;
            this.txtTien.Name = "txtTien";
            this.txtTien.ReadOnly = true;
            this.txtTien.Size = new System.Drawing.Size(91, 24);
            this.txtTien.TabIndex = 17;
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoLuong.FormattingEnabled = true;
            this.cbSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbSoLuong.Location = new System.Drawing.Point(169, 279);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(82, 24);
            this.cbSoLuong.TabIndex = 16;
            this.cbSoLuong.SelectedIndexChanged += new System.EventHandler(this.cbSoLuong_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "$";
            // 
            // cbChonDoUong
            // 
            this.cbChonDoUong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonDoUong.FormattingEnabled = true;
            this.cbChonDoUong.Items.AddRange(new object[] {
            "Coca Cola",
            "Pepsi",
            "Seven Up"});
            this.cbChonDoUong.Location = new System.Drawing.Point(35, 279);
            this.cbChonDoUong.Name = "cbChonDoUong";
            this.cbChonDoUong.Size = new System.Drawing.Size(108, 24);
            this.cbChonDoUong.TabIndex = 14;
            this.cbChonDoUong.SelectedIndexChanged += new System.EventHandler(this.cbChonDoUong_SelectedIndexChanged);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(245, 330);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(125, 32);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm &Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemDs
            // 
            this.btnThemDs.Location = new System.Drawing.Point(64, 330);
            this.btnThemDs.Name = "btnThemDs";
            this.btnThemDs.Size = new System.Drawing.Size(113, 32);
            this.btnThemDs.TabIndex = 12;
            this.btnThemDs.Text = "Thêm Vào DS";
            this.btnThemDs.UseVisualStyleBackColor = true;
            this.btnThemDs.Click += new System.EventHandler(this.btnThemDs_Click);
            // 
            // rdoNuaNgay
            // 
            this.rdoNuaNgay.AutoSize = true;
            this.rdoNuaNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNuaNgay.Location = new System.Drawing.Point(207, 89);
            this.rdoNuaNgay.Name = "rdoNuaNgay";
            this.rdoNuaNgay.Size = new System.Drawing.Size(102, 22);
            this.rdoNuaNgay.TabIndex = 11;
            this.rdoNuaNgay.TabStop = true;
            this.rdoNuaNgay.Text = "Nửa Ngày";
            this.rdoNuaNgay.UseVisualStyleBackColor = true;
            this.rdoNuaNgay.CheckedChanged += new System.EventHandler(this.rdoNuaNgay_CheckedChanged);
            // 
            // rdoCaNgay
            // 
            this.rdoCaNgay.AutoSize = true;
            this.rdoCaNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCaNgay.Location = new System.Drawing.Point(38, 89);
            this.rdoCaNgay.Name = "rdoCaNgay";
            this.rdoCaNgay.Size = new System.Drawing.Size(93, 22);
            this.rdoCaNgay.TabIndex = 10;
            this.rdoCaNgay.TabStop = true;
            this.rdoCaNgay.Text = "Cả Ngày";
            this.rdoCaNgay.UseVisualStyleBackColor = true;
            this.rdoCaNgay.CheckedChanged += new System.EventHandler(this.rdoCaNgay_CheckedChanged);
            // 
            // txtGiaDuThuyen
            // 
            this.txtGiaDuThuyen.Location = new System.Drawing.Point(157, 133);
            this.txtGiaDuThuyen.Name = "txtGiaDuThuyen";
            this.txtGiaDuThuyen.ReadOnly = true;
            this.txtGiaDuThuyen.Size = new System.Drawing.Size(179, 22);
            this.txtGiaDuThuyen.TabIndex = 9;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(157, 39);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(179, 22);
            this.txtHT.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn Đồ Uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá Du Thuyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(389, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 74);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.Location = new System.Drawing.Point(273, 18);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 53);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDS);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(389, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 376);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // lstDS
            // 
            this.lstDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDS.FormattingEnabled = true;
            this.lstDS.ItemHeight = 16;
            this.lstDS.Location = new System.Drawing.Point(3, 18);
            this.lstDS.Name = "lstDS";
            this.lstDS.Size = new System.Drawing.Size(405, 355);
            this.lstDS.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.ComboBox cbSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbChonDoUong;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemDs;
        private System.Windows.Forms.RadioButton rdoNuaNgay;
        private System.Windows.Forms.RadioButton rdoCaNgay;
        private System.Windows.Forms.TextBox txtGiaDuThuyen;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstDS;
    }
}

