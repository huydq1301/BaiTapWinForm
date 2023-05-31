using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*|Document|*.doc|Rich Text Format|*.rtf";
            ofd.FilterIndex = 1;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    rtfSave.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            if(fd.ShowDialog()== DialogResult.OK)
            {
                rtfSave.SelectionFont = fd.Font; //thiet lap font cho van ban duoc chon
                rtfSave.SelectionColor = fd.Color;    
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtfSave.BackColor = cd.Color;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd= new SaveFileDialog();
            sfd.Filter = "All Files|*.*|Document|*.doc|Rich Text Format|*.rtf";
            sfd.InitialDirectory = "C:\\Users\\Huy\\Downloads";
            sfd.FilterIndex = 1;
            sfd.AddExtension = true;
            sfd.DefaultExt = ".rtf";
            if(sfd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter file=new StreamWriter(sfd.FileName);
                try
                {
                    file.Write(rtfSave.Text);
                    MessageBox.Show("Saved Success!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                file.Close();
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtfSave.SelectedText);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtfSave.SelectedText);
            rtfSave.SelectedText = " ";
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            rtfSave.SelectedText=Clipboard.GetText();
        }

       
    }
}
