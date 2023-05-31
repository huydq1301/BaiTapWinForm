using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_0
{
    class ThiSinh
    {
        private string SBD;
        private string HT;
        private double m1;
        private double m2;
        private double m3;
        public string Sbd {
            get { return SBD; }
            set{ SBD= value; }
            }
        public string Ht
        {
            get { return HT; }
            set { HT = value; }
        }
        public double M1
        {
            get { return m1; }
            set { m1 = value; }
        }
        public double M2
        {
            get { return m2; }
            set { m2 = value; }
        }
        public double M3
        {
            get { return m3; }
            set { m3 = value; }
        }
        public ThiSinh(string SBD, string HT, double m1, double m2, double m3)
        {
            this.SBD = SBD;
            this.HT = HT;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public ThiSinh()
        {
            this.SBD = "";
            this.HT = "";
            this.m1 = 0;
            this.m2 = 0;
            this.m3 = 0;
        }
        public  void NhapTS()
        {
            Console.Write("Moi nhap SBD: ");
            SBD = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap Ho Ten: ");
            HT = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap diem mon 1: ");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Moi nhap diem mon 2: ");
            m2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Moi nhap diem mon 3: ");
            m3 = Convert.ToDouble(Console.ReadLine());
        }
        public  void XuatTS()
        {
            Console.Write( "SBD: "+ this.SBD+ "\tHo Ten: "+ this.HT + "\tMon 1: "+ this.m1 + "\tMon 2: "+ this.m2, "\tMon 3: "+ this.m3);
        }
        public double TongDiem()
        {
            return M1 + M2 + M3;
        }
    }
}
