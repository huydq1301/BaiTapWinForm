using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV2
{
     class sv
    {
        private string MSV;
        private string HT;
        private string NS;
        private double DLT;
        private double DCSDL;
        private double DTB;
        public  sv()
        {
            MSV = "";
            HT = "";
            NS = "";
            DLT = 0;
            DCSDL = 0;
            DTB = 0;
        }
        public sv(string _MSV, string _HT, double _DLT, double _DCSDL, double _DTB )
        {
            this.MSV = _MSV;
            this.HT = _HT;
            this.DLT = _DLT;
            this.DCSDL=_DCSDL;
            this.DTB = _DTB;
        }
        public void nhap()
        {
            Console.Write("\nMoi nhap ma sv: ");
            MSV = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap ho ten sv: ");
            HT = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap ngay sinh sv: ");
            NS = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap diem lap trinh cua sv: ");
            DLT= Convert.ToDouble(Console.ReadLine());
            Console.Write("Moi nhap diem co so du lieu cua sv: ");
            DCSDL = Convert.ToDouble(Console.ReadLine());
            

        }
        public double GetDTB()
        {
            return (DLT + DCSDL) / 2;
        }
        public string GetMSV()
        {
            return MSV;
        }
        public void xuat()
        {
            this.DTB=this.GetDTB();
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5}", "Ma sv", "Ho Ten", "Nam Sinh", "Diem TB");
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5}", this.MSV, this.HT, this.NS, this.DTB);
        }
           
    }
}
