using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach A;
            A=new DanhSach();
            A.nhapds();
            A.xuatds();
            Console.WriteLine("DS Sv co diem tb>=8:");
            A.LietKe();
            A.sapxep();
            Console.WriteLine("DS sau khi sap xep:");
            A.xuatds();
            Console.ReadKey();
        }
    }
}
