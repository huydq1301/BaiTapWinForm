using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHoHCN
{class CH
    {
        int maphong;
        HCN kichthuoc;
        public HCN Kichthuoc
        {
            set { kichthuoc = value; }
            get { return kichthuoc; }
        }
        public void nhapch()
        {
            Console.WriteLine("Moi nhap ma phong can ho: ");
            maphong =int.Parse ( Console.ReadLine());
            kichthuoc = new HCN();
            kichthuoc.nhap();
        }
        public void xuatch (){ Console.Write("\nma phong:" + maphong.ToString());
            kichthuoc.xuat(); Console.Write("dien tich:" + kichthuoc .tinhdt ().ToString ());
        }
    }

}
