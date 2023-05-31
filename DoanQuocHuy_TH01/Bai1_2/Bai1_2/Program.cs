
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            ThueXe[] ds;
            Console.Write("Moi nhap so luong nguoi thue: ");
            n=Convert.ToInt32(Console.ReadLine());
            ds = new ThueXe[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Moi nhap thong tin nguoi thu " + (i + 1));
                ds[i] = new ThueXe();
                ds[i].nhap();
            }
            Console.WriteLine("Thong tin: ");
            for (int i = 0; i < n; i++)
            {
                ds[i].xuat();
            }
        }
    }
}
