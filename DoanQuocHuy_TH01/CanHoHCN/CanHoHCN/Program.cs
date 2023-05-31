using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHoHCN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Moi nhap so can ho: ");
            n = Convert.ToInt16(Console.ReadLine());
            CHNew[] h = new CHNew[n+3];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Moi nhap can ho thu " + i);
                h[i] = new CHNew();
                h[i].nhapCHNew();
            }
            for (int i = 1; i <= n; i++)
            {

                h[i].xuatCHNew();
            }
            double max;
            CHNew chmax = h[1];
            max = h[1].Kichthuoc.tinhdt();
            for (int i = 2; i <= n; i++)
                if (max < h[i].Kichthuoc.tinhdt())
                { 
                    max = h[i].Kichthuoc.tinhdt(); 
                    chmax = h[i]; 
                }
            Console.Write("can hoc co dien tich max:"); chmax.xuatCHNew();
            string huongTk; 
            bool kq = false;
            Console.WriteLine("Moi nhap huong can ho can tim: ");
            huongTk = Convert.ToString(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                if (string.Compare(huongTk, h[i].HuongBanCong, true) == 0)
                {
                    kq = true; 
                    break;
                }
            if (kq == false) 
                Console.Write("Khong co can ho nao co huong ban cong nhu tren");
            else
            {
                Console.WriteLine("\nKQ tim:\n");
                for (int i=1; i <= n; i++) 
                    if (string.Compare(huongTk, h[i].HuongBanCong, true) == 0) 
                        h[i].xuatCHNew();
            }
            Console.ReadKey();
        }
    }
}
