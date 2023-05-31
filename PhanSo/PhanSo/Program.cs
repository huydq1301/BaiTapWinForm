using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PS A, B, Tong;
            A = new PS();
            B = new PS();
            Tong = new PS();
            Console.WriteLine("Moi nhap phan so A \n");
            A.nhap();
            Console.Write("Moi nhap phan so B \n");
            B.nhap();
            C.Tong(A,B);
            Console.WriteLine("\nTong cua A + B = ");
            C.xuat();
            C.Hieu(A,B);
            Console.WriteLine("\nHieu cua A - B = ");
            C.xuat();
            C.Tich(A,B);
            Console.WriteLine("\nTich cua A * B = ");
            C.xuat();
            int k;
            C.Thuong(A,B,ref k);
            if(k == -1)
                Console.WriteLine("Khong the tinh thuong");
            else
            {
                Console.WriteLine("\nThuong cua A / B = ");
                C.xuat();
            }
            
            Console.Write("A sau khi rut gon la:  ");
            A.xuat();
            Console.Write("B sau khi rut gon la:  ");
            B.xuat();
            Console.ReadKey();
        }
    }
}
