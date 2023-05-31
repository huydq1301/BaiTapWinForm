using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHoHCN
{
    class CHNew : CH
    {
        string HuongBC;
        public CHNew() : base()
        {
            HuongBC = "Huong Nam";
        }
        public string HuongBanCong
        {
            set { HuongBC = value; }
            get { return HuongBC; }
        }
        public void nhapCHNew()
        {
            base.nhapch();
            Console.Write("nhap huong ban cong can ho:");
            HuongBC = Convert.ToString(Console.ReadLine());
        }
        public void xuatCHNew()
        {
            base.xuatch();
            Console.WriteLine("\nhuong ban cong:" + HuongBC);
        }
    }

}
