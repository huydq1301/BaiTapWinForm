namespace VietChuongTrinhNgheNhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDS = new System.Windows.Forms.ListBox();
            this.cbbThuMuc = new System.Windows.Forms.ComboBox();
            this.cbbODia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtfLoiBaiHat = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox1.Controls.Add(this.lstDS);
            this.groupBox1.Controls.Add(this.cbbThuMuc);
            this.groupBox1.Controls.Add(this.cbbODia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // lstDS
            // 
            this.lstDS.FormattingEnabled = true;
            this.lstDS.ItemHeight = 16;
            this.lstDS.Location = new System.Drawing.Point(6, 154);
            this.lstDS.Name = "lstDS";
            this.lstDS.Size = new System.Drawing.Size(434, 180);
            this.lstDS.TabIndex = 5;
            this.lstDS.DoubleClick += new System.EventHandler(this.lstDS_DoubleClick);
            // 
            // cbbThuMuc
            // 
            this.cbbThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThuMuc.FormattingEnabled = true;
            this.cbbThuMuc.Location = new System.Drawing.Point(114, 78);
            this.cbbThuMuc.Name = "cbbThuMuc";
            this.cbbThuMuc.Size = new System.Drawing.Size(185, 24);
            this.cbbThuMuc.TabIndex = 4;
            this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(this.cbbThuMuc_SelectedIndexChanged);
            // 
            // cbbODia
            // 
            this.cbbODia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbODia.FormattingEnabled = true;
            this.cbbODia.Location = new System.Drawing.Point(114, 37);
            this.cbbODia.Name = "cbbODia";
            this.cbbODia.Size = new System.Drawing.Size(185, 24);
            this.cbbODia.TabIndex = 3;
            this.cbbODia.SelectedIndexChanged += new System.EventHandler(this.cbbODia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tập Tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư Mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ Đĩa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtfLoiBaiHat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(440, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 541);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  ";
            // 
            // rtfLoiBaiHat
            // 
            this.rtfLoiBaiHat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfLoiBaiHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfLoiBaiHat.Location = new System.Drawing.Point(3, 18);
            this.rtfLoiBaiHat.Name = "rtfLoiBaiHat";
            this.rtfLoiBaiHat.ReadOnly = true;
            this.rtfLoiBaiHat.Size = new System.Drawing.Size(349, 520);
            this.rtfLoiBaiHat.TabIndex = 0;
            this.rtfLoiBaiHat.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 343);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(434, 195);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ví dụ Combobox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox lstDS;
        private System.Windows.Forms.ComboBox cbbThuMuc;
        private System.Windows.Forms.ComboBox cbbODia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtfLoiBaiHat;
    }
}

