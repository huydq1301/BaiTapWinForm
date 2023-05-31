using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyTS A = new QuanLyTS();
            double x;
            A.nhapds();
            Console.WriteLine("Danh Sach Thi Sinh La:");
            A.xuatds();
            Console.WriteLine("Moi nhap Diem chuan: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Danh Sach Thi Sinh Trung Tuyen La: ");
            A.XuatDsTrungTuyen(x);
            Console.ReadKey();
        }
    }
}
