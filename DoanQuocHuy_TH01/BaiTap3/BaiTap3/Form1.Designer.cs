namespace BaiTap3
{
    partial class BaiTap3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(270, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giai Phuong Trinh Bac 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhap b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhap c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ket Qua:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(287, 71);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(239, 27);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(287, 145);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(239, 27);
            this.txtB.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(287, 211);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(239, 27);
            this.txtC.TabIndex = 7;
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKQ.ForeColor = System.Drawing.Color.Silver;
            this.txtKQ.Location = new System.Drawing.Point(287, 275);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(239, 77);
            this.txtKQ.TabIndex = 8;
            this.txtKQ.Text = "Phuong Trinh Vo Nghiem";
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(87, 393);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(94, 29);
            this.btnGiai.TabIndex = 9;
            this.btnGiai.Text = "&Giai PT";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnLL
            // 
            this.btnLL.Location = new System.Drawing.Point(331, 393);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(94, 29);
            this.btnLL.TabIndex = 10;
            this.btnLL.Text = "&Lam Lai";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.btnLL_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(547, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "&Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // BaiTap3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaiTap3";
            this.Text = "Bai Tap 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtKQ;
        private Button btnGiai;
        private Button btnLL;
        private Button btnThoat;
    }
}