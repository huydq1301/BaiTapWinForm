using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
     class DSSV
    {
        private SV[] ds;
        private int n;
        public void nhapds()
        {
            do
            {
                Console.Write("Moi nhap so luong sinh vien: ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            while (n <= 0);
            

            ds = new SV[n];
            Console.Write("\nNhap danh sach sinh vien\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nMoi nhap sinh vien thu " + (i + 1));
                ds[i] = new SV();
                ds[i].Nhap();
            }
        }
        public int checkKL()
        {
            int count1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (ds[i].checkTB() == true && ds[i].DTB() >= 8)
                    count1++;
            }
            return count1;
        }
        public int checkTN()
        {
            int count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (ds[i].checkTB() == true)
                    count2++;
            }
            return count2;
        }
    }
}
