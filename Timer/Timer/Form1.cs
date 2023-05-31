namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int m, s;
            m = int.Parse(txtPhut.Text);
            s = int.Parse(txtGiay.Text);
            if(s>0&& s<=59)
            {
                s -= 1;
            }
            else
            {
                if(s==0 &&m>0)
                {
                    s = 59;
                    m -= 1;
                }
                if(s==0&&m==0)
                {
                    timer4.Stop();
                    MessageBox.Show("Da het gio");
                }
            }
            txtPhut.Text = m.ToString();
            txtGiay.Text = s.ToString();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            txtGiay.Text = "0";
            txtPhut.Text = "0";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer4.Stop();
        }
    }
}