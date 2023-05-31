namespace TinhToanTrenDaySo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtn = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.btnnhap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblSX = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtn
            // 
            this.txtn.AutoSize = true;
            this.txtn.Location = new System.Drawing.Point(41, 34);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(57, 20);
            this.txtn.TabIndex = 0;
            this.txtn.Text = "&Nhap n";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(41, 97);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(57, 20);
            this.lblday.TabIndex = 1;
            this.lblday.Text = "Day so:";
            this.lblday.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(41, 327);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(94, 29);
            this.btnnhap.TabIndex = 2;
            this.btnnhap.Text = "Nhap day";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 27);
            this.textBox1.TabIndex = 3;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(41, 161);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(112, 20);
            this.lblTong.TabIndex = 4;
            this.lblTong.Text = "Tong day so la: ";
            // 
            // lblSX
            // 
            this.lblSX.AutoSize = true;
            this.lblSX.Location = new System.Drawing.Point(41, 231);
            this.lblSX.Name = "lblSX";
            this.lblSX.Size = new System.Drawing.Size(183, 20);
            this.lblSX.TabIndex = 5;
            this.lblSX.Text = "Sap xep day so giam dan: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Tinh tong";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLL
            // 
            this.btnLL.Location = new System.Drawing.Point(473, 327);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(94, 29);
            this.btnLL.TabIndex = 7;
            this.btnLL.Text = "&Lam Lai";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.btnLL_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(646, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "&Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSX
            // 
            this.btnSX.Location = new System.Drawing.Point(328, 327);
            this.btnSX.Name = "btnSX";
            this.btnSX.Size = new System.Drawing.Size(94, 29);
            this.btnSX.TabIndex = 9;
            this.btnSX.Text = "&Sap Xep";
            this.btnSX.UseVisualStyleBackColor = true;
            this.btnSX.Click += new System.EventHandler(this.btnSX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSX);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSX);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.txtn);
            this.Name = "Form1";
            this.Text = "Tinh toan tren day so";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtn;
        private Label lblday;
        private Button btnnhap;
        private TextBox textBox1;
        private Label lblTong;
        private Label lblSX;
        private Button button1;
        private Button btnLL;
        private Button btnThoat;
        private Button btnSX;
    }
}