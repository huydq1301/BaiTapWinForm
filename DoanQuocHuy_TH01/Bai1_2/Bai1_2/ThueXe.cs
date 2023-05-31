using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_2
{
    class ThueXe
    {
        private string HT;
        private int SoGio;
        private string LoaiXe;
        public string Ht
        { get { return this.HT; }
          set { this.HT = value; } 
        }
        public int Sogio
        {
            get { return this.SoGio; }
            set { this.SoGio = value; }
        }
        public string Loaixe
        {
            get { return this.LoaiXe; }
            set { this.LoaiXe = value; }
        }
        public ThueXe()
        {
            this.HT = "";
            SoGio = 0;
            LoaiXe = "";
        }
        public void nhap()
        {
            Console.Write("Moi nhap Ho Ten: ");
            this.HT = Convert.ToString(Console.ReadLine());
            Console.Write("Moi nhap so gio thue xe: ");
            this.SoGio = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Moi nhap loai xe thue: ");
                this.LoaiXe = Convert.ToString(Console.ReadLine());
            }
            while (this.LoaiXe != "xe tai" && this.LoaiXe != "xe du lich");
        }
        public int TongTien()
        {
            int sum=0;
            if (this.LoaiXe == "xe tai")
                sum = 220 + 85 * (this.SoGio-1);
            else
                sum = 250 + 70 * (this.SoGio-1);
            return sum;
        }
        public void xuat()
        {
            Console.WriteLine("\nHo Ten: "+this.HT+"\tLoai Xe: "+this.LoaiXe+"\tSo Gio: "+this.SoGio+"\tThanh tien: "+this.TongTien());
        }

    }
}
