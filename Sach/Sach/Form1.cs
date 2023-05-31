namespace Sach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = -1;
        SachMoi[] ds;
        int count = 0;
        private void btnN_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "")
            {
                MessageBox.Show("Ban chua nhap N");
            }
            else
                if (txtN.Text == "0")
                {
                    MessageBox.Show("N phai khac 0");
                    n = -1;
                    txtN.Text = "";
                }
                else
                {
                    try
                    {
                        n = int.Parse(txtN.Text);
                        ds = new SachMoi[n];
                    }
                    catch
                    {
                        n = -1;
                        MessageBox.Show("N phai la so nguyen duong");
                    }
                }

        }
        private void btnNhap_Click(object sender, EventArgs e)

        {
            if (n == -1)
            {
                MessageBox.Show("Ban chua nhap N");
            }
            else
            {
                string MaSach; string TenSach; string TenTg; int Sl; string QrCode;
                if (count < n)
                {
                    if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtTacGia.Text == "" || txtSoLuong.Text == "" || txtMaQrCode.Text == "")
                    {
                        MessageBox.Show("Ban can nhap day du thong tin!!!");
                    }
                    else
                    {
                        try
                        {
                            int SoLuong = Convert.ToInt32(txtSoLuong.Text);
                            MaSach = txtMaSach.Text;
                            TenSach = txtTenSach.Text;
                            TenTg = txtTacGia.Text;
                            Sl = SoLuong;
                            QrCode = txtMaQrCode.Text;
                            ds[count] = new SachMoi(MaSach, TenSach, TenTg, Sl, QrCode);
                            dataview.Rows.Add(MaSach, TenSach, TenTg, Sl, QrCode);
                            count++;

                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("So Luong Sach phai la so nguyen");
                        }

                    }
                }
                else
                {
                    if (count >= n)
                    {
                        MessageBox.Show("Ban da nhap du so sach");
                    }
                }
            }
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtSoLuong.Text = "";
            txtMaQrCode.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(count < n )
            {
                MessageBox.Show("Ban chua nhap du so sach!");
            }
            else
            {
                int check = 0;
                string Tim = txtTimKiem.Text;
                if (Tim == "")
                {
                    MessageBox.Show("Ban chua nhap Ma Qrcode can tim!");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (String.Compare(Tim, ds[i].getQrCode(), true) == 0)
                        {
                            MessageBox.Show("So Luong Sach Co Ma QrCode " + ds[i].getQrCode() + " con ton la : " + ds[i].getSl() );
                            check = 1;
                            dataview.Rows.Clear();
                            dataview.Rows.Add(ds[i].getMaSach(), ds[i].getTenSach(), ds[i].getTenTg(), ds[i].getSl(), ds[i].getQrCode());
                        }
                    }
                    if (check == 0)
                        MessageBox.Show("Khong co sach nao co Ma Qrcode nhu tim kiem!");
                }
                txtTimKiem.Text = "";
            }
            
        }
    }
}