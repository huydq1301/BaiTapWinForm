using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Mang
    {
        private int n;
        private int[] pt;
        
        public Mang()
        {

        }
        public Mang(int n)
        {
            this.n = n;
            pt = new int[n];
            for(int i = 0; i < n; i++)
                pt[i] = 0;
        }
        public void nhap()
        {
            do
            {
                Console.Write("Moi nhap so phan tu cua mang= ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);
            pt = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Moi nhap phan tu thu " + (i + 1));
                pt[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void xuat()
        {
            Console.WriteLine("\nDanh sach phan tu cua mang la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(pt[i] + " ");
            }
        }
        public void SapXep(int thutu)
        {
            int temp;
            if (thutu == 1)
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (pt[i] < pt[j])
                        {
                            temp = pt[i];
                            pt[i] = pt[j];
                            pt[j] = temp;
                        }
                    }
                }
            else
                if (thutu == 0)
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (pt[i] > pt[j])
                        {
                            temp = pt[i];
                            pt[i] = pt[j];
                            pt[j] = temp;
                        }
                    }
                }
        }
        public int TimKiem(int m)
        {
            int k=-1;
            for (int i = 0; i < n; i++)
                if (pt[i] == m)
                {
                     k=i;
                    break;
                }
            return k;
        }
    }
}
