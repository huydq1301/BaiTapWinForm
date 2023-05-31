namespace TinhTongHaiSo
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(77, 45);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(57, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Nhập a";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(77, 128);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(58, 20);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Nhập b";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(303, 45);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(267, 27);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(303, 125);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(267, 27);
            this.txtB.TabIndex = 3;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(77, 212);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(43, 20);
            this.lblTong.TabIndex = 4;
            this.lblTong.Text = "Tổng";

            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(45, 325);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(137, 52);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "Tính tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnLL
            // 
            this.btnLL.Location = new System.Drawing.Point(250, 325);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(137, 52);
            this.btnLL.TabIndex = 6;
            this.btnLL.Text = "Làm lại";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.btnLL_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(484, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 52);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(658, 478);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Chuong trinh tinh tong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblTong;
        private Button btnTong;
        private Button btnLL;
        private Button btnThoat;
    }
}