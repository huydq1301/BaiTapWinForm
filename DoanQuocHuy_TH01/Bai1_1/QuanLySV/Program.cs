using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
     class Program
    {
        static void Main(string[] args)
        {
            DSSV DS = new DSSV();
            DS.nhapds();
            int a, b;
            a = DS.checkKL();
            b = DS.checkTN();
            Console.Write("\nSo sinh vien duoc lam khoa luan la " + a);
            Console.Write("\nSo sinh vien duoc lam tot nghiep la " + b);
            Console.ReadKey();
        }
    }
}
