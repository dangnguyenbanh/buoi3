using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    class Program
    {
        static void Main(string[] args)
        {

            TamGiac TG1 = new TamGiac(2, 6, 5);
            TamGiac TG2 = new TamGiac(3, 3, 3);
            TamGiac TG3 = new TamGiac(3, 5, 3);
            TamGiac TG4 = new TamGiac(-1, 6, 5);
            Console.WriteLine("Tam giac 1 la");
            TG1.xuat();
            Console.WriteLine("Tam giac 2 la");
            TG2.xuat();
            Console.WriteLine("Tam giac 3 la");
            TG3.xuat();
            Console.WriteLine("Tam giac 4 la");
            TG4.xuat();
            Console.ReadKey();
        }
    }
}
