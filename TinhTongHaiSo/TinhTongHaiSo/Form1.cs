using System.Windows.Forms;

namespace TinhTongHaiSo
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lblTong.ForeColor = Color.Black;
            lblTong.Text = "Tổng";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnTong_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số nguyên");
                txtA.Focus();
                txtB.Focus();//dat con tro vao textBox1
                return; //dung lai
            }
            int s = 0;
            for(int i = a; i <= b; i++)
                s += i;
            if(s == 0)
            {
                MessageBox.Show("Bạn phải nhập số  A nhỏ hơn số B");
                txtA.Focus();
                txtB.Focus();//dat con tro vao textBox1
                return;
            }
            else
            {
                lblTong.ForeColor = Color.Red;
                lblTong.Text = "Tổng từ " + txtA.Text + " đến " + txtB.Text + " là : " + s;
            }
                
        }
    }
}