using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    class Vehide
    {
        private string ChuXe;

        public string ChuXe1
        {
            get { return ChuXe; }
            set { ChuXe = value; }
        }
        private string LoaiXe;

        public string LoaiXe1
        {
            get { return LoaiXe; }
            set { LoaiXe = value; }
        }
        private double GiaXe;

        public double GiaXe1
        {
            get { return GiaXe; }
            set { if(value >=0)
                GiaXe = value; 
            else throw new ArgumentOutOfRangeException("Gia xe phai tren 0");
        }
        private double DungTich;

        public double DungTich1
        {
            get { return DungTich; }
            set {if(value>=0) 
                DungTich = value;
            else throw new ArgumentOutOfRangeException("dung tich khong am");
        }
        public Vehide(string chuxe, string loaixe,double giaxe,double dungtich )
        {
            this.ChuXe = chuxe;
            this.LoaiXe = loaixe;
            this.GiaXe = giaxe;
            this.DungTich = dungtich;
        }
    }
}
