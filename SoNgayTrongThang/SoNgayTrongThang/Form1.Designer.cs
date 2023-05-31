namespace SoNgayTrongThang
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
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblKq = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btnKq = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(58, 48);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(90, 20);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Nhập tháng:";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(58, 143);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(81, 20);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Nhập năm:";
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Location = new System.Drawing.Point(58, 250);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(69, 20);
            this.lblKq.TabIndex = 4;
            this.lblKq.Text = " Kết Quả:";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(217, 48);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(200, 27);
            this.txtThang.TabIndex = 1;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // btnKq
            // 
            this.btnKq.Location = new System.Drawing.Point(47, 327);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(116, 58);
            this.btnKq.TabIndex = 5;
            this.btnKq.Text = "&Kết quả";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // btnLL
            // 
            this.btnLL.Location = new System.Drawing.Point(248, 327);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(126, 58);
            this.btnLL.TabIndex = 6;
            this.btnLL.Text = "&Làm lại";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.btnLL_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(447, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 58);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(217, 143);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(200, 27);
            this.txtNam.TabIndex = 8;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(640, 433);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnKq);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Name = "Form1";
            this.Text = "Chương trình tính số ngày trong tháng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblThang;
        private Label lblNam;
        private Label lblKq;
        private TextBox txtThang;
        private Button btnKq;
        private Button btnLL;
        private Button btnThoat;
        private TextBox txtNam;
    }
}