using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Matrix
{
    
        class Matrix
        {
        private int[,] a; //Mảng 2 chiều
        public int m { get; set; }
        public int n { get; set; }

        public Matrix()
            {
                this.m = 0;
                this.n = 0;
                a = new int[m, n];
            }
            public Matrix(int m, int n)
            {
                this.m = m;
                this.n = n;
                a = new int[m, n];
            }
            public void nhap()
            {

                Console.Write("\nMoi nhap so hang = ");
                m = Convert.ToInt16(Console.ReadLine());
                Console.Write("\nMoi nhap so cot = ");
                n = Convert.ToInt16(Console.ReadLine());
                a = new int[m, n];
                for (int i = 0; i < this.m; i++)
                {
                    for (int j = 0; j < this.n; j++)
                    {
                        Console.WriteLine("Moi nhap phan tu [{0}, {1}] =", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

            }
            public void xuat()
            {
                Console.WriteLine("\nMa tran la: ");
                for (int i = 0; i < this.m; i++)
                {
                    for (int j = 0; j < this.n; j++)
                    {
                        Console.Write(this.a[i, j] + "    ");
                    }
                    Console.WriteLine();
                }

            }
            public static Matrix operator +(Matrix A, Matrix B)
            {
                Matrix C;
                C = new Matrix(A.m, A.n);
                for (int i = 0; i < C.m; i++)
                {
                    for (int j = 0; j < C.n; j++)
                        C.a[i, j] = A.a[i, j] + B.a[i, j];
                }
                return C;
            }
        public static Matrix operator -(Matrix A, Matrix B)
        {
            Matrix C;
            C = new Matrix(A.m, A.n);
            for (int i = 0; i < C.m; i++)
            {
                for (int j = 0; j < C.n; j++)
                    C.a[i, j] = A.a[i, j] - B.a[i, j];
            }
            return C;
        }
        public static Matrix operator *(Matrix A, Matrix B)
            {
                Matrix C;
                C = new Matrix(A.m, A.n);
                    for (int i = 0; i < A.m; ++i)
                    {
                        for (int j = 0; j < B.n; ++j)
                        {
                            C.a[i, j] = 0;
                            for (int h = 0; h < A.n; ++h)
                                C.a[i, j] = C.a[i, j] + (A.a[i, h] * B.a[h, j]);
                        }
                    }
                return C;

            }
            public void ChuyenVi()
            {
                if (Check() != true)
                    Console.WriteLine("Khong phai ma tran vuong khong the chuyen vi!");
                else
                {
                    int temp;
                    for (int i = 1; i < this.m; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            temp = a[i, j];
                            a[i, j] = a[j, i];
                            a[j, i] = temp;
                        }
                    }
                    this.xuat();
                }
            }
            public bool Check()
            {
                if (this.m == this.n)
                    return true;
                else
                    return false;
            }
        }
}
