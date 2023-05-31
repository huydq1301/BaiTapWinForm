namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text = " This is Display!";
            txtBox.BackColor = Color.Yellow;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            txtBox.BackColor = Color.White;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_MouseHover(object sender, EventArgs e)
        {
            txtBox.BackColor= Color.Red;
        }

        private void txtBox_MouseLeave(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.Green;
        }
    }
}