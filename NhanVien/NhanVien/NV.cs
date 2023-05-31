using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class NV
    {
        private string HT;
        private string NS;
        private string DC;
        private double LCB;
        private double HS;
        private double PhuCap;
        private double TT;
        public NV()
        {
            HT = "";
            NS = "";
            DC = "";
            LCB = 0;
            HS = 0;
            PhuCap = 0;
            TT = 0;
        }
        public void nhap()
        {
            Console.Write("Moi nhap Ho Ten: ");
            HT= Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap Ngay Sinh: ");
            NS = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap Dia Chi: ");
            DC = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap Luong Co Ban: ");
            LCB= Convert.ToDouble(Console.ReadLine());
            Console.Write("Moi nhap Luong He So: ");
            HS = Convert.ToDouble(Console.ReadLine());
            Console.Write("Moi nhap Luong Phu Cap: ");
            PhuCap = Convert.ToDouble(Console.ReadLine());
        }
        public double GetTT()
        {
            return LCB * HS + PhuCap;
        }
        public void xuat()
        {
            this.TT = this.GetTT();
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5}","Ho Ten","Ngay Sinh", "Dia Chi", "Tong Tien");
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5}", this.HT, this.NS, this.DC, this.TT);
        }
    }
}
