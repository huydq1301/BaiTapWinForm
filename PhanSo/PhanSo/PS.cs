using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class PS
    {
        private int T;
        private int M;
        public PS()
        {
            this.T = 0;
            this.M = 1;
        }
        public PS(int a, int b)
        {
            this.T = a;
            this.M = b;
        }
        public void nhap()
        {
            Console.Write("Moi nhap tu so: ");
            this.T = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Moi nhap mau so: ");
                this.M = Convert.ToInt32(Console.ReadLine());
            } while (this.M == 0);
        }
        public void xuat()
        {
            string s = T + "/" + M + "\n";
            Console.Write(s);
        }
        public PS Tong(PS A, PS B)
        {
            PS C;
            C.T = A.T * B.M + A.M * B.T;
            C.M = A.M * B.M;
            C.RutGon();
            return C;
        }
        public PS Hieu(PS A, PS B)
        {
            PS C;
            C.T = A.T * B.M - A.M * B.T;
            C.M = A.M * B.M;
            C.RutGon();
            return C;
        }
        public PS Tich(PS A, PS B)
        {
            PS C;
            C.T = A.T * B.T;
            C.M = A.M * B.M;
            C.RutGon();
            return C;
        }
        public PS Thuong(PS A, PS B, ref int k)
        {
            k=0;
            PS C;
            C.T = A.T * B.M ;
            C.M = A.M * B.T;
            if(C.M==0)
                k=-1;
            C.RutGon();
            return C;
        }


        public void RutGon()
        {
            int a = UCLN(this.T, this.M);
            if (a > 0)
            {
                this.T = this.T / a;
                this.M = this.M / a;
            }
            else
            {
                this.T = this.T / (-a);
                this.M = this.M / (a);
            }
        }
        private int UCLN(int a, int b)
        {

            if (a != 0)
            {
                if (a > 0)
                {
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
                else
                {
                    a = -a;
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
            }
            else return 0;

        }
    }
}
