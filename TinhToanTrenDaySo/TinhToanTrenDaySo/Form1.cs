namespace TinhToanTrenDaySo
{
    public partial class Form1 : Form
    {
        int n;
        int[] a;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            string s="Day so la: ";

            //lay gia tri n
            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ban phai nhap so nguyen");
                textBox1.Focus(); //dat con tro vao textBox1
                return; //dung lai
            }

            a = new int[n];
            //sinh day so
            Random rd= new Random();
            for(int i=0; i<n; i++)
            {
                a[i]= rd.Next(100);
                s = s + "   " + a[i];
            }
            lblday.Text = s;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ban chua nhap day so");
                textBox1.Focus(); //dat con tro vao textBox1
                return; //dung lai
            }
            int S = 0;
            foreach (int item in a)
            {
                S = S + item;
            }
            lblTong.Text = "Tong day la:     " + S.ToString();

        }

        private void btnSX_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ban chua nhap day so");
                textBox1.Focus(); //dat con tro vao textBox1
                return; //dung lai
            }
            String sx=" Day sau khi sap xep giam dan : ";
            Array.Sort(a);
            for (int i = 0; i < n; i++)
            {
                sx = sx + "   " + a[i];
            }
            lblSX.Text = sx;

        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            lblday.Text = "Day so: ";
            lblTong.Text = "Tong day so la: ";
            lblSX.Text = "Sap xep day so giam dan: ";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Ban co muon thoat khong?",
                "Co hay Khong", MessageBoxButtons.YesNo , 
                MessageBoxIcon.Question) == DialogResult.Yes)
                   this.Close();

        }

 
    }
}