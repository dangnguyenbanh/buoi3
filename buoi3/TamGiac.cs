using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    class TamGiac
    {
        private double CanhA;

        public double CanhA1
        {
            get { return CanhA; }
            set { CanhA = value; }
        }
        private double CanhB;

        public double CanhB1
        {
            get { return CanhB; }
            set { CanhB = value; }
        }
        private double CanhC;

        public double CanhC1
        {
            get { return CanhC; }
            set { CanhC = value; }
        }
        public TamGiac()
        {
            CanhA = 0;
            CanhB = 0;
            CanhC = 0;
        }
        public TamGiac(double A,double B,double C)
        {
            if (A <= 0 || B <= 0 || C <= 0 || A + B <= C || A + C <= B || B + C <= A)
            {
                CanhA = 0;
                CanhB = 0;
                CanhC = 0;
            }
            else
            CanhA = A;
            CanhB = B;
            CanhC = C;
        }
        public double TinhChuVi()
        {
            return CanhA + CanhB + CanhC;
        }
        public double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
        }
        public string LoaiTamGiac()
        {
            if (CanhA == CanhB && CanhB == CanhC)
            {
                return "Tam giac deu";
            }
            else if( CanhA ==CanhB || CanhB==CanhC || CanhA==CanhC)
            {
                return "Tam giac can";
            }
            else if (CanhA + CanhB >= CanhC && CanhA + CanhC >= CanhB && CanhB + CanhC >= CanhA)
            {
                return "tam giac thuong";
            }
            else
            {
                return "day khong phai la tam giac";
            }
        }
        public void xuat()
        {
            Console.WriteLine("Ba canh cua tam giac la({0} ; {1} ;  {2}) ;tam giac nay la {3} ;  Chu vi tam giac la {4}, Dien tich tam giac la {5}", CanhA, CanhB, CanhC, LoaiTamGiac(), TinhChuVi(), TinhDienTich());
        }   
    }

}
