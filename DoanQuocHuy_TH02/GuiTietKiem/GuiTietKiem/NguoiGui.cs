using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiTietKiem
{
    class NguoiGui
    {
        private int Ma;
        private string HT;
        private string DC;
        private int SoTienGui;
        private string NgayGui;
        private string ThoiGianGui;
        private double Tien;
        public NguoiGui(int ma)
        {
            Ma=ma;
        }
        public NguoiGui(int maKH, string tenKH, string diaChi, int soTienGui, string ngayGui, string thoiGianGui, double tien)
        {
            Ma = maKH;
            HT = tenKH;
            DC = diaChi;
            SoTienGui = soTienGui;
            NgayGui = ngayGui;
            ThoiGianGui = thoiGianGui;
            Tien = tien;
        }
        public int MaKH { get => Ma; set => Ma = value; }
        public string TenKH { get => HT; set => HT = value; }
        public double TienTra { get => Tien; set => Tien = value; }
    }
    class StaticData
    {
        public static List<NguoiGui> _NguoiGui = new List<NguoiGui>();
    }
}
