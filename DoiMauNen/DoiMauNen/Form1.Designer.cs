namespace DoiMauNen
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
            this.TxtDoiMau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.HsbBlue = new System.Windows.Forms.HScrollBar();
            this.HsbGreen = new System.Windows.Forms.HScrollBar();
            this.HsbRed = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDoiMau
            // 
            this.TxtDoiMau.Location = new System.Drawing.Point(56, 23);
            this.TxtDoiMau.Multiline = true;
            this.TxtDoiMau.Name = "TxtDoiMau";
            this.TxtDoiMau.Size = new System.Drawing.Size(697, 191);
            this.TxtDoiMau.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBlue);
            this.groupBox1.Controls.Add(this.lblGreen);
            this.groupBox1.Controls.Add(this.lblRed);
            this.groupBox1.Controls.Add(this.HsbBlue);
            this.groupBox1.Controls.Add(this.HsbGreen);
            this.groupBox1.Controls.Add(this.HsbRed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon Mau Nen Cho TextBox";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(639, 161);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(0, 20);
            this.lblBlue.TabIndex = 8;
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGreen.Location = new System.Drawing.Point(639, 107);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(0, 20);
            this.lblGreen.TabIndex = 7;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(639, 41);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(0, 20);
            this.lblRed.TabIndex = 6;
            // 
            // HsbBlue
            // 
            this.HsbBlue.Location = new System.Drawing.Point(82, 155);
            this.HsbBlue.Maximum = 255;
            this.HsbBlue.Name = "HsbBlue";
            this.HsbBlue.Size = new System.Drawing.Size(527, 26);
            this.HsbBlue.TabIndex = 5;
            this.HsbBlue.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // HsbGreen
            // 
            this.HsbGreen.Location = new System.Drawing.Point(82, 101);
            this.HsbGreen.Maximum = 255;
            this.HsbGreen.Name = "HsbGreen";
            this.HsbGreen.Size = new System.Drawing.Size(527, 26);
            this.HsbGreen.TabIndex = 4;
            this.HsbGreen.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // HsbRed
            // 
            this.HsbRed.Location = new System.Drawing.Point(72, 41);
            this.HsbRed.Maximum = 255;
            this.HsbRed.Name = "HsbRed";
            this.HsbRed.Size = new System.Drawing.Size(527, 26);
            this.HsbRed.TabIndex = 3;
            this.HsbRed.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtDoiMau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtDoiMau;
        private GroupBox groupBox1;
        private Label lblBlue;
        private Label lblGreen;
        private Label lblRed;
        private HScrollBar HsbBlue;
        private HScrollBar HsbGreen;
        private HScrollBar HsbRed;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}