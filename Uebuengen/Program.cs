using System;
using System.Collections.Generic;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 4;
            (x,y) = FalseSwap(x, y);

            Console.WriteLine($"x: {x}\t y: {y}");
        }

        static (double, string ) FalseSwap(double a, double b)
        {
            
            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a: {a} und b:{b}");
            return (a, b.ToString());

        }
    }
}



