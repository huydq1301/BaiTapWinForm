namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LstSV_Click(object sender, EventArgs e)
        {
            string sv=LstSV.SelectedItem.ToString();
            string[] detailStudent = sv.Split('|');
            txtMa.Text = detailStudent[0];
            txtTen.Text=  detailStudent[1];
            if (detailStudent[2] == "Nam")
                RadNam.Checked = true;
            else
                RadNu.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiem tra du lieu nhap sv tu lam
            string student, gt;
            if (RadNu.Checked == true)
                gt = "Nu";
            else
                gt = "Nam";
            student = txtMa.Text + "|" + txtTen.Text + "|" + gt;
            //add student vao listbox
            LstSV.Items.Add(student);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index=LstSV.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Ban chua chon phan tu de xoa");
                return;
            }
            else
                if (MessageBox.Show("Ban co chac chan muon xoa khong", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                LstSV.Items.RemoveAt(index);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string student, gt;
            int index = LstSV.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Ban chua chon phan tu de sua");
                return;
            }
            else
            {
                if (RadNu.Checked == true)
                    gt = "Nu";
                else
                    gt = "Nam";
                student = txtMa.Text + "|" + txtTen.Text + "|" + gt;
                //add student vao listbox
                LstSV.Items[index] = student;
            }
                
        }
    }
}