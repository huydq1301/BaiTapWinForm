using System.Text.RegularExpressions;

namespace BaiTap3
{
    public partial class BaiTap3 : Form
    {
        public BaiTap3()
        {
            InitializeComponent();
        }

        //private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        //{
            
        //        Regex regex =null;
        //        regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
           
        //    if (regex.IsMatch(e.KeyChar.ToString())==false)
        //    {
        //        MessageBox.Show("Ban phai nhap so thuc");
        //        e.Handled = true;// chan ky tu vua nhap lai
        //    }
        //}

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double d=0, x1=0, x2=0;
            double a=0, b=0, c=0;
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Ban chua nhap so");
                return;
            }
            txtKQ.ForeColor = Color.Black;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        txtKQ.Text = "Phuong trinh co vo so nghiem";
                    }
                    else
                    {
                        txtKQ.Text = "Phuong trinh vo nghiem";
                    }
                }
                else
                {
                    txtKQ.Text = "Phuong trinh co nghiem duy nhat x= " + (-b / c).ToString();
                }
            }
            else
            {
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    txtKQ.Text = "Phuong trinh co nghiem  x1= " + x1.ToString() + "\tx2= " + x2.ToString();
                }
                else
                {
                    if (d == 0)
                    {
                        txtKQ.Text = "Phuong trinh co nghiem kep x1 = x2 = " + (-b / 2 * a).ToString();
                    }
                    else
                    {
                        txtKQ.Text = "Phuong trinh vo nghiem";
                    }
                }
            }
                
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtKQ.Text = "Phuong Trinh Vo Nghiem";
            txtKQ.ForeColor= Color.Silver;
            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong?",
                "Co hay Khong", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}