﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_QLBanHang.FormBTL
{
    public partial class HDN : Form
    {
        public HDN()
        {
            InitializeComponent();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietHDN ctHDN = new ChiTietHDN();
            ctHDN.ShowDialog();
        }
    }
}
