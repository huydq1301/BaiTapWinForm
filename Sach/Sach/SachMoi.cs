using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    class SachMoi:SachCu
    {
        private string QrCode;
        public SachMoi(string MaSach, string TenSach, string TenTg, int Sl, string QrCode)
        : base(MaSach, TenSach, TenTg, Sl)
        {
            this.QrCode = QrCode;
        }
        ~SachMoi()
        {

        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Moinhap ma QrCode: ");
            QrCode = Convert.ToString(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("{5,5}", this.QrCode);
        }
        public string getQrCode()
        {
            return QrCode;
        }
        

    }
}
