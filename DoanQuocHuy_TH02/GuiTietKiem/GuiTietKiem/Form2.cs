using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiTietKiem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listNguoiGuis = StaticData._NguoiGui;
        }
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
        private void btnTK_Click(object sender, EventArgs e)
        {
            int timthay = 0;
            string ThongTinTK;
            foreach (NguoiGui a in listNguoiGuis)
            {
                //lstDS.Items.Clear();
                if (a.MaKH == Convert.ToInt32(txtTK.Text))
                {
                    timthay = 1;
                    ThongTinTK = "Khách hàng " + a.TenKH + " đươc nhận "
                        + a.TienTra + " nghìn đồng";
                    lstDS.Items.Add(ThongTinTK);
                }
            }

            if (timthay == 0)
            {
                ThongTinTK = "Khách hàng co ma: " + txtTK.Text + " không có trong danh sách";
                lstDS.Items.Add(ThongTinTK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
