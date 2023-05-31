using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogExmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpen=new OpenFileDialog();
            odlgOpen.Filter = "JPEG Images|*.jpg|PNG Images|*.png|Bitmap Images|*.bmp|All Files|*.*";
            odlgOpen.FilterIndex = 4;
            odlgOpen.Title = "Select a image File to open";
            if(odlgOpen.ShowDialog()==DialogResult.OK) //khi nguoi dung click nut open;
                picImage.Image=Image.FromFile(odlgOpen.FileName);
        }
    }
}
