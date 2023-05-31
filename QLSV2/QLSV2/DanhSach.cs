using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV2
{
     class DanhSach
    {
        private int n;
        private sv[] ds;
        public DanhSach()
        {
            this.n = 0;
            ds = new sv[0];
        }
        public DanhSach(int n)
        {
            this.n = n;
            ds = new sv[n];
        }
        public void nhapds()
        {
            do
            {
                Console.Write("Moi nhap so luong sinh vien: ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            while (n <= 0);


            ds = new sv[n];
            Console.Write("\nNhap danh sach sinh vien\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nMoi nhap sinh vien thu " + (i + 1));
                ds[i] = new sv();
                ds[i].nhap();
            }
        }
        public void xuatds()
        {
            Console.Write("\nDanh sach sinh vien la:\n");
            for (int i = 0; i < n; i++)
            {
                ds[i].xuat();
            }
        }
        public void LietKe()
        {
            int count = 0;
            Console.WriteLine("Danh Sach sinh vien co trong danh sach");
            for (int i = 0; i < n; i++)
                if (ds[i].GetDTB() >= 8)
                {
                    ds[i].xuat();
                    count++;
                }

            if (count == 0)
                Console.WriteLine("Khong co sinh vien nao co DTB > 8.0");
        }
        public void sapxep()
        {
            sv Temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (String.Compare(ds[i].GetMSV(), ds[j].GetMSV(), true) > 0)
                    {
                        Temp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = Temp;
                    }
                }
            }
        }
    }
}
