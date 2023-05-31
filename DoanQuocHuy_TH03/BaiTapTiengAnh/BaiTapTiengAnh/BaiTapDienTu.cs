using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTiengAnh
{
    class BaiTapDienTu
    {
        private string debai;
        private string dapan;
        private List<string> dapantungcau;
        public BaiTapDienTu()
        {
            this.debai = "";
            this.dapan = "";
            this.dapantungcau = new List<string>();
        }
        public BaiTapDienTu(string debai, string dapan)
        {
            this.Debai = debai;
            this.Dapan = dapan;
        }
        public BaiTapDienTu(string debai, string dapan, List<string> dapantungcau)
        {
            this.Debai1 = debai;
            this.Dapan1 = dapan;
            this.Dapantungcau = dapantungcau;
        }
        public string Debai { get { return Debai1; } set { Debai1 = value; } }
        public string Dapan { get { return Dapan1; } set { Dapan1 = value; } }
        public string Debai1 { get { return debai; } set { debai = value; } }
        public string Dapan1 { get { return dapan; } set { dapan = value; } }
        public List<string> Dapantungcau { get { return dapantungcau; } set { dapantungcau = value; }}
    }
    class StaticData
    {
        public static List<BaiTapDienTu> bt = new List<BaiTapDienTu>();
    }
    class DataClick
    {
        public static int check;
    }
}
