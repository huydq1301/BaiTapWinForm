using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
     class SV
    {
        private string HT;
        private string NS;
        private double DiemLt;
        private double DiemCsdl;
        private double DiemTkw;
        
        public SV()
        {
            HT = "";
            NS = "";
            DiemLt = 0;
            DiemCsdl = 0;
            DiemTkw = 0;
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("\nNhập Tên SV:");
            HT = Console.ReadLine();
            Console.Write("Nhập Ngày Sinh:");
            NS = Console.ReadLine();
            do
            {
                Console.Write("Nhập Điểm Lập Trình:");
                DiemLt = Convert.ToDouble(Console.ReadLine());
            } while (DiemLt < 0 || DiemLt > 10);
            do
            {
                Console.Write("Nhập Điểm Cơ Sở Dữ Liệu:");
                DiemCsdl = Convert.ToDouble(Console.ReadLine());
            } while (DiemCsdl < 0 || DiemCsdl > 10);
            do
            {
                Console.Write("Nhập Điểm Thiết Kế Web:");
                DiemTkw = Convert.ToDouble(Console.ReadLine());
             } while (DiemTkw < 0 || DiemTkw > 10);
        }
        public double DTB()
        {
            double DTB;
            DTB = (DiemLt + DiemCsdl + DiemTkw);
            if (DTB == 0)
                return 0;
            else
                return DTB / 3;
        }
        public bool checkTB()
        {
            if (DiemLt >= 5 && DiemTkw >= 5 && DiemCsdl >= 5)
                return true;
            else
                return false;
        }
    }
}
