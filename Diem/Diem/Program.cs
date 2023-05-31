using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diem A, B;
            A= new Diem();
            B= new Diem();
            Console.WriteLine("Moi nhap diem A: ");
            A.nhap();
            Console.WriteLine("Moi nhap diem B: ");
            B.nhap();
            Console.WriteLine("Toa do cua A: ");
            A.xuat(); 
            Console.WriteLine("Toa do cua B: ");
            B.xuat();
            double kc = A.KhoangCach(A, B);
            Console.WriteLine("Khoang cach cua hai diem A va B: " +Math.Round(kc,2));
            Console.ReadKey();

        }
    }
}
