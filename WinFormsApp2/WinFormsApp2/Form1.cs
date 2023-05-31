using System.Net.Http.Headers;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadXanh_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            txtChange.ForeColor = rd.ForeColor;
        }

        private void radVnTime_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd= sender as RadioButton;
            txtChange.Font = new Font(rd.Text, txtChange.Font.Size,txtChange.Font.Style);
        }
        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk=sender as CheckBox;
            txtChange.Font = new Font(txtChange.Font.Name, txtChange.Font.Size, txtChange.Font.Style ^ chk.Font.Style);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(Control ct in this.Controls)
            {
                if (ct is GroupBox)
                {
                    foreach (Control item in ct.Controls)
                        if (item is CheckBox)
                        {
                            CheckBox t = item as CheckBox;
                            t.Checked = false;
                        }
                        else
                        {
                            if(item is RadioButton)
                            {
                                RadioButton k = item as RadioButton;
                                k.Checked = false;
                            }
                        }
                }
                txtChange.Font = new Font("Microsof San Serif", 28, FontStyle.Regular);
                txtChange.ForeColor = Color.Black;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}