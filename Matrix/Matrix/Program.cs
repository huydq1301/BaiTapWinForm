using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix A, B, Tong, Hieu, Tich;
            A = new Matrix();
            B = new Matrix();
            Tong = new Matrix();
            Hieu = new Matrix();
            Tich = new Matrix();
            int check1=0, check2=0, check3=0;
            Console.WriteLine("Moi nhap ma tran A: ");
            A.nhap();
            A.xuat();
            Console.WriteLine("Moi nhap ma tran B: ");
            B.nhap();
            B.xuat();
            Console.WriteLine("Cong hai ma tran: ");
            if (A.n != B.n || A.m != B.m)
                Console.WriteLine("Hai ma tran khong cung cap khong the cong!");
            else
            {
                Tong = A + B;
                Tong.xuat();
            }
            Console.WriteLine("Hieu hai ma tran: ");
            if (A.n != B.n || A.m != B.m)
                Console.WriteLine("Hai ma tran khong cung cap khong the tru!");
            else
            {
                Hieu = A - B;
                Hieu.xuat();
            }
            Console.WriteLine("Tich hai ma tran: ");
            if (A.n != B.m)
                Console.WriteLine("Hai ma tran khong the tinh tich!");
            else
            {
                Tich = A * B;
                Tich.xuat();
            }
            Console.WriteLine("Ma tran A sau khi chuyen vi la: \n");
            A.ChuyenVi();
            bool k = A.Check();
            Console.WriteLine("Kiem tra ma tran vuong: ");
            if (k == true)
                Console.WriteLine("A la ma tran vuong!");
            else
                Console.WriteLine("A khong la ma tran vuong!");
            Console.ReadKey();
        }
    }
}
