using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diem
{
    class Diem
    {
        private double x;
        private double y;
        public Diem()
        {
            this.x = 0;
            this.y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void nhap()
        {
          
            Console.Write("\nMoi nhap hoanh do x= ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nMoi nhap tung do y= ");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public void xuat()
        {
            string s = "( " + x + " , " + y + ")";
            Console.WriteLine(s);
        }
        public double KhoangCach(Diem A, Diem B)
        {
            double kc = 0;
            kc = Math.Pow((B.x - A.x), 2) + Math.Pow((B.y - A.y), 2);
            return Math.Sqrt(kc);
        }
    }
}
