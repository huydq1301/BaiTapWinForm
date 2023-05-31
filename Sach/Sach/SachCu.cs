using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    class SachCu
    {
        private string MaSach;
        private string TenSach;
        private string TenTg;
        private int Sl;
        public SachCu(string MaSach, string TenSach, string TenTg, int Sl )
        {
            this.MaSach = MaSach;
            this.MaSach = MaSach;
            this.TenTg = TenTg;
            this.Sl = Sl;
        }
        ~SachCu()
        {

        }
        public string getMaSach()
        {
            return MaSach;
        }
        public string getTenSach()
        {
            return TenSach;
        }
        public string getTenTg()
        {
            return TenTg;
        }
        public int getSl()
        {
            return Sl;
        }
        public virtual void nhap()
        {
            Console.Write("Moi nhap ma sach: ");
            MaSach  =Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap ten sach: ");
            TenSach = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap ten tac gia: ");
            TenTg = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap so luong : ");
            Sl = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("{0, 5} , {1,5}, {2,5}, {3,5}, {4,5}", "Ma Sach", "Ten Sach ", " Ten Tac Gia", "So Luong","Ma QrCode");
            Console.WriteLine("{0, 5} , {1,5}, {2,5}, {3,5}", this.MaSach, this.TenSach, this.TenTg, this.Sl);
        }
    }
}
