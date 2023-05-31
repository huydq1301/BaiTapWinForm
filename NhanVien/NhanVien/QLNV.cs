using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class QLNV
    {
        NV[] ds;
        int n;
        public QLNV()
        {
            n = 0;
            ds= new NV[0];
        }
        public QLNV(int n)
        {
            this.n = n;
            ds = new NV[n];
        }
        public void nhapds()
        {
             do
            {
                Console.WriteLine("Moi nhap so nhan vien =");
                 n=Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);
            
            ds=new NV[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Moi nhap nhan vien thu " + (i + 1));
                ds[i] = new NV();
                ds[i].nhap();
            } 
        }
        public void xuatds()
        {
            for (int i = 0; i < n; i++)
            {
                ds[i].xuat();
            }
        }
    }
}
