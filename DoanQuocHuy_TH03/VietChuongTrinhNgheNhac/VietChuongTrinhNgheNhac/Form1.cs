using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietChuongTrinhNgheNhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {
                cbbODia.Items.Add(d.Name);
            }
        }

        private void cbbODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbThuMuc.Items.Clear();
            DirectoryInfo Directory = new DirectoryInfo(cbbODia.Text);
            DirectoryInfo[] Directories = Directory.GetDirectories("*.*");
            FileInfo[] files = Directory.GetFiles();
            foreach (DirectoryInfo d in Directories)
            {
                cbbThuMuc.Items.Add(d.Name);
            }
        }

        private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDS.Items.Clear();
            rtfLoiBaiHat.Text = "";
            string[] files = Directory.GetFiles(cbbODia.Text+cbbThuMuc.Text);
            foreach (string d in files)
            {
                    lstDS.Items.Add(d);
            }
        }

        private void lstDS_DoubleClick(object sender, EventArgs e)
        {
            
            if (lstDS.SelectedIndex!=-1)
            {
                axWindowsMediaPlayer1.URL = lstDS.Text;
                string[] TenBaiHat = lstDS.Text.Split('.');
                string txtDuongDanLoiBaiHat = TenBaiHat[0] + ".txt";
                string rtfDuongDanLoiBaiHat = TenBaiHat[0] + ".rtf";
                if(File.Exists(txtDuongDanLoiBaiHat)==true)
                {
                    rtfLoiBaiHat.Text = File.ReadAllText(txtDuongDanLoiBaiHat);
                }
                else
                {
                    if(File.Exists(rtfDuongDanLoiBaiHat) == true)
                    {
                        rtfLoiBaiHat.Text = File.ReadAllText(rtfDuongDanLoiBaiHat);
                    }
                    else
                    {
                        rtfLoiBaiHat.Text= "Loi Bai Hat Khong Ton Tai";
                    }
                }

            }
           
            
        }
    }
}
