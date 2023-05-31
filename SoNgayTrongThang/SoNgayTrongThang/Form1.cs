namespace SoNgayTrongThang
{
    public partial class Form1 : Form
    {
        int a, b, Count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            txtNam.Text = "";
            txtThang.Text = "";
            lblKq.Text = "Kết quả";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Count++;
            if(Count%4==0)
            {
                this.BackColor=Color.Red;
            }
            if(Count%4==1)
            {
                this.BackColor=Color.Green;
            }
            if(Count%4==2)
            {
                this.BackColor= Color.Blue;
            }
            if(Count%4==3)
            {
                this.BackColor = Color.Pink;
            }

        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && Convert.ToInt16(e.KeyChar)!=8)
            {
                MessageBox.Show("Ban phai nhap so");
                e.Handled = true;// chan ky tu vua nhap lai
            }
                
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath.ToString() + "bin\\Debug\\ICON\\shortcut8.ico");
            Count = 0;
            this.BackColor = Color.Gray;
        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(txtThang.Text);
                b = int.Parse(txtNam.Text);
            }
            catch
            {
                MessageBox.Show("Ban phai nhap so nguyen");
                txtThang.Focus();
                txtNam.Focus();
                return;//dung lai
            }
            int SoNgay = 0;
            switch(a)
            {
                case 1:

                case 3:

                case 5:

                case 7:

                case 8:

                case 10:

                case 12:

                    SoNgay = 31;
                    break;

                case 4:

                case 6:

                case 9:

                case 11:
                    SoNgay = 30;
                    break;
                case 2:
                    if ((b % 4 == 0 && b % 100 != 0) || b % 400 == 0)
                        SoNgay = 29;
                    else
                        SoNgay = 28;
                    break;
            }
            if (a < 1 || a > 12 || b < 1000 || b > 9999)
            {
                MessageBox.Show("Tháng phải có giá trị từ 1 đến 12, năm gồm 4 chữ số.");
                txtNam.Focus();
                txtThang.Focus();
                return;
            }
            else
                lblKq.Text = "Tháng " + a + " năm " + b + " có " + SoNgay + " ngày.";

        }
    }
}