using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_0
{
    class QuanLyTS
    {
        private int n;
        private TS[] ds;
        public QuanLyTS()
        {
            this.n = 0;
            ds = new TS[0];
        }
        public QuanLyTS(int n)
        {
            this.n = n;
            ds = new TS[n];
        }
        public void nhapds()
        {
            do
            {
                Console.Write("Moi nhap so luong thi sinh: ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            while (n <= 0);
            ds = new TS[n+5];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Moi nhap thong tin sinh vien thu : "+ (i + 1));
                ds[i] = new TS();
                ds[i].Nhap();
            }
        }
        public void xuatds()
        {
            for (int i = 0; i < n; i++)
            {
                ds[i].Xuat();
            }
        }
        public void XuatDsTrungTuyen(double x)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (ds[i].Tong() >= x)
                {
                    count++;
                    ds[i].Xuat();
                }
            }
            if (count == 0)
                Console.Write("Khong co thi sinh nao trung tuyen!");
        }

    }
}
