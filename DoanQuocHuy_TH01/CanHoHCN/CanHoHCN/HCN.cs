using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHoHCN
{
    class HCN
    {
        double cd;
        double cr;
        public void nhap()
        {
            Console.WriteLine("Moi nhap chieu dai can ho: ");
            cd = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap chieu rong can ho: ");
            cr = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("\ncd " + cd.ToString("0.00") + " cr " + cr.ToString("0.00"));
        }
        public double Cd
        {
            get { return cd; }
            set { cd = value; }
        }
        public double Cr
        {
            get { return cr; }
            set { cr = value; }
        }
        public double tinhdt()
        {
            return cd * cr;
        }
    }

}
