namespace ExampleSQL
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
            this.txtTenCL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvTn = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenCL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaCL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin chất liệu";
            // 
            // txtTenCL
            // 
            this.txtTenCL.Location = new System.Drawing.Point(502, 65);
            this.txtTenCL.Name = "txtTenCL";
            this.txtTenCL.Size = new System.Drawing.Size(203, 22);
            this.txtTenCL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten Chat Lieu";
            // 
            // txtMaCL
            // 
            this.txtMaCL.Location = new System.Drawing.Point(118, 68);
            this.txtMaCL.Name = "txtMaCL";
            this.txtMaCL.Size = new System.Drawing.Size(203, 22);
            this.txtMaCL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Chat Lieu";
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnThem);
            this.groupBoxChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxChucNang.Location = new System.Drawing.Point(600, 165);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(200, 285);
            this.groupBoxChucNang.TabIndex = 1;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = " ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(64, 55);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvTn
            // 
            this.dgvTn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTn.Location = new System.Drawing.Point(0, 165);
            this.dgvTn.Name = "dgvTn";
            this.dgvTn.RowHeadersWidth = 51;
            this.dgvTn.RowTemplate.Height = 24;
            this.dgvTn.Size = new System.Drawing.Size(600, 285);
            this.dgvTn.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTn);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenCL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTn;
    }
}

