namespace DoiMauNen
{
    public partial class Form1 : Form
    {
        int red, green, blue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            red = HsbRed.Value;
            green = HsbGreen.Value;
            blue = HsbBlue.Value;   
            lblRed.Text = red.ToString();
            lblGreen.Text = green.ToString();
            lblBlue.Text = blue.ToString();
            TxtDoiMau.BackColor=Color.FromArgb(red, green, blue);
        }
    }
}