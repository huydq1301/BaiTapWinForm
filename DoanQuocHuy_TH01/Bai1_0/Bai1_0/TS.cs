using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_0
{
    class TS : ThiSinh
    {
        private string KV;
        public string Kv
        {
            get { return KV; }
            set { KV = value; }
        }
        public TS():base()
        {
            this.KV = "";
        }
        public TS(string SBD, string HT, double m1, double m2, double m3,string KV):base(SBD, HT, m1, m2, m3)
        {
            this.KV = KV;
        }
        public void Nhap()
        {
            base.NhapTS();
            do
            {
                Console.Write("Moi nhap khu vuc: ");
                KV = Convert.ToString(Console.ReadLine());
            }
            while (KV !="3" && KV!="1" && KV!="2");
            
        }
        public  void Xuat()
        {
            double Td = this.Tong();
            base.XuatTS();
            Console.Write("\tKhu vuc: "+  this.KV+"\tTong Diem: "+ Td+"\n");
        }
        public double Tong()
        {
            double Kq = this.TongDiem();
            if (KV == "1")
                Kq += 0;
            if (KV == "2")
                Kq += 1;
            if (KV == "3")
                Kq += 2;
            return Kq;
        }
        
    }
}
