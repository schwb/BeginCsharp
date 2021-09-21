using System;
using System.Collections.Generic;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            string b = "3.14";
            double c = 15.6;
            (b, c, a) = DreichfachSwap(a, b, c);
            Console.WriteLine($"{b}, {c}, {a}");
        }
        static (string, double, int) DreichfachSwap(int egal, string was, double hiersteht)
        {
            string d = Convert.ToString(egal);
            double e = Convert.ToDouble(was);
            int f = Convert.ToInt32(hiersteht);
            return (d, e, f);
        }
    }
}



