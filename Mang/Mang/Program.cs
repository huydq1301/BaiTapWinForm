using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Mang A;
            A= new Mang();
            A.nhap();
            A.xuat();
            int thutu;
            Console.Write("\nBan muon sap xep day theo tang dan hay giam dan ( nhap 0 tang dan, nhap 1 giam dan): ");
            thutu= Convert.ToInt16(Console.ReadLine());
            A.SapXep(thutu);
            A.xuat();
            int m;
            Console.Write("\nNhap so ma ban can tim: ");
            m = Convert.ToInt32(Console.ReadLine());
            int vt = A.TimKiem(m);
            if (vt == -1)
                Console.WriteLine("\nSo ban can tim khong co trong mang");
            else
                Console.Write("\nSo ban tim nam o vi tri thu "+ (vt+1) +" trong mang");
            Console.ReadKey();
        }
    }
}
