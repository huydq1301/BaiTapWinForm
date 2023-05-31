namespace WinFormsApp2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTahoma = new System.Windows.Forms.RadioButton();
            this.radArial = new System.Windows.Forms.RadioButton();
            this.radSimsun = new System.Windows.Forms.RadioButton();
            this.radVnTime = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkUnderline = new System.Windows.Forms.CheckBox();
            this.Chkstrickoout = new System.Windows.Forms.CheckBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadTim = new System.Windows.Forms.RadioButton();
            this.RadLaCay = new System.Windows.Forms.RadioButton();
            this.RadDo = new System.Windows.Forms.RadioButton();
            this.RadXanh = new System.Windows.Forms.RadioButton();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTahoma);
            this.groupBox1.Controls.Add(this.radArial);
            this.groupBox1.Controls.Add(this.radSimsun);
            this.groupBox1.Controls.Add(this.radVnTime);
            this.groupBox1.Location = new System.Drawing.Point(52, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu Font";
            // 
            // radTahoma
            // 
            this.radTahoma.AutoSize = true;
            this.radTahoma.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radTahoma.Location = new System.Drawing.Point(12, 176);
            this.radTahoma.Name = "radTahoma";
            this.radTahoma.Size = new System.Drawing.Size(84, 22);
            this.radTahoma.TabIndex = 3;
            this.radTahoma.TabStop = true;
            this.radTahoma.Text = "Tahoma";
            this.radTahoma.UseVisualStyleBackColor = true;
            this.radTahoma.CheckedChanged += new System.EventHandler(this.radVnTime_CheckedChanged);
            // 
            // radArial
            // 
            this.radArial.AutoSize = true;
            this.radArial.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radArial.Location = new System.Drawing.Point(12, 126);
            this.radArial.Name = "radArial";
            this.radArial.Size = new System.Drawing.Size(54, 24);
            this.radArial.TabIndex = 2;
            this.radArial.TabStop = true;
            this.radArial.Text = "Arial";
            this.radArial.UseVisualStyleBackColor = true;
            this.radArial.CheckedChanged += new System.EventHandler(this.radVnTime_CheckedChanged);
            // 
            // radSimsun
            // 
            this.radSimsun.AutoSize = true;
            this.radSimsun.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radSimsun.Location = new System.Drawing.Point(12, 81);
            this.radSimsun.Name = "radSimsun";
            this.radSimsun.Size = new System.Drawing.Size(76, 19);
            this.radSimsun.TabIndex = 1;
            this.radSimsun.TabStop = true;
            this.radSimsun.Text = "Simsun";
            this.radSimsun.UseVisualStyleBackColor = true;
            this.radSimsun.CheckedChanged += new System.EventHandler(this.radVnTime_CheckedChanged);
            // 
            // radVnTime
            // 
            this.radVnTime.AutoSize = true;
            this.radVnTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radVnTime.Location = new System.Drawing.Point(12, 37);
            this.radVnTime.Name = "radVnTime";
            this.radVnTime.Size = new System.Drawing.Size(76, 21);
            this.radVnTime.TabIndex = 0;
            this.radVnTime.TabStop = true;
            this.radVnTime.Text = "VnTime";
            this.radVnTime.UseVisualStyleBackColor = true;
            this.radVnTime.CheckedChanged += new System.EventHandler(this.radVnTime_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkUnderline);
            this.groupBox2.Controls.Add(this.Chkstrickoout);
            this.groupBox2.Controls.Add(this.ChkItalic);
            this.groupBox2.Controls.Add(this.ChkBold);
            this.groupBox2.Location = new System.Drawing.Point(306, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu ứng";
            // 
            // ChkUnderline
            // 
            this.ChkUnderline.AutoSize = true;
            this.ChkUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ChkUnderline.Location = new System.Drawing.Point(6, 174);
            this.ChkUnderline.Name = "ChkUnderline";
            this.ChkUnderline.Size = new System.Drawing.Size(95, 24);
            this.ChkUnderline.TabIndex = 3;
            this.ChkUnderline.Text = "Underline";
            this.ChkUnderline.UseVisualStyleBackColor = true;
            this.ChkUnderline.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // Chkstrickoout
            // 
            this.Chkstrickoout.AutoSize = true;
            this.Chkstrickoout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.Chkstrickoout.Location = new System.Drawing.Point(6, 126);
            this.Chkstrickoout.Name = "Chkstrickoout";
            this.Chkstrickoout.Size = new System.Drawing.Size(89, 21);
            this.Chkstrickoout.TabIndex = 2;
            this.Chkstrickoout.Text = "Strickoout";
            this.Chkstrickoout.UseVisualStyleBackColor = true;
            this.Chkstrickoout.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ChkItalic.Location = new System.Drawing.Point(6, 79);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(63, 24);
            this.ChkItalic.TabIndex = 1;
            this.ChkItalic.Text = "Italic";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChkBold.Location = new System.Drawing.Point(6, 37);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(63, 24);
            this.ChkBold.TabIndex = 0;
            this.ChkBold.Text = "Bold";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadTim);
            this.groupBox3.Controls.Add(this.RadLaCay);
            this.groupBox3.Controls.Add(this.RadDo);
            this.groupBox3.Controls.Add(this.RadXanh);
            this.groupBox3.Location = new System.Drawing.Point(559, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mầu chữ";
            // 
            // RadTim
            // 
            this.RadTim.AutoSize = true;
            this.RadTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RadTim.Location = new System.Drawing.Point(16, 173);
            this.RadTim.Name = "RadTim";
            this.RadTim.Size = new System.Drawing.Size(55, 24);
            this.RadTim.TabIndex = 3;
            this.RadTim.TabStop = true;
            this.RadTim.Text = "Tím";
            this.RadTim.UseVisualStyleBackColor = true;
            this.RadTim.CheckedChanged += new System.EventHandler(this.RadXanh_CheckedChanged);
            // 
            // RadLaCay
            // 
            this.RadLaCay.AutoSize = true;
            this.RadLaCay.ForeColor = System.Drawing.Color.Green;
            this.RadLaCay.Location = new System.Drawing.Point(16, 126);
            this.RadLaCay.Name = "RadLaCay";
            this.RadLaCay.Size = new System.Drawing.Size(73, 24);
            this.RadLaCay.TabIndex = 2;
            this.RadLaCay.TabStop = true;
            this.RadLaCay.Text = "Lá Cây";
            this.RadLaCay.UseVisualStyleBackColor = true;
            this.RadLaCay.CheckedChanged += new System.EventHandler(this.RadXanh_CheckedChanged);
            // 
            // RadDo
            // 
            this.RadDo.AutoSize = true;
            this.RadDo.ForeColor = System.Drawing.Color.Red;
            this.RadDo.Location = new System.Drawing.Point(16, 81);
            this.RadDo.Name = "RadDo";
            this.RadDo.Size = new System.Drawing.Size(50, 24);
            this.RadDo.TabIndex = 1;
            this.RadDo.TabStop = true;
            this.RadDo.Text = "Đỏ";
            this.RadDo.UseVisualStyleBackColor = true;
            this.RadDo.CheckedChanged += new System.EventHandler(this.RadXanh_CheckedChanged);
            // 
            // RadXanh
            // 
            this.RadXanh.AutoSize = true;
            this.RadXanh.ForeColor = System.Drawing.Color.Blue;
            this.RadXanh.Location = new System.Drawing.Point(16, 37);
            this.RadXanh.Name = "RadXanh";
            this.RadXanh.Size = new System.Drawing.Size(63, 24);
            this.RadXanh.TabIndex = 0;
            this.RadXanh.TabStop = true;
            this.RadXanh.Text = "Xanh";
            this.RadXanh.UseVisualStyleBackColor = true;
            this.RadXanh.CheckedChanged += new System.EventHandler(this.RadXanh_CheckedChanged);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(110, 24);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(538, 27);
            this.txtChange.TabIndex = 3;
            this.txtChange.Text = "Microsoft visual C#";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(199, 371);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(472, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radTahoma;
        private RadioButton radArial;
        private RadioButton radSimsun;
        private RadioButton radVnTime;
        private GroupBox groupBox2;
        private CheckBox ChkUnderline;
        private CheckBox Chkstrickoout;
        private CheckBox ChkItalic;
        private CheckBox ChkBold;
        private GroupBox groupBox3;
        private RadioButton RadXanh;
        private TextBox txtChange;
        private RadioButton RadTim;
        private RadioButton RadLaCay;
        private RadioButton RadDo;
        private Button btnReset;
        private Button btnExit;
    }
}