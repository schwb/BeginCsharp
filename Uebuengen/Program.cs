using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie eine Zahl ein.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben sie eine Zahl ein.");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("Zahl1 ist größer als Zahl2.");
            }
            else
            {
                Console.WriteLine("Zahl2 ist größer als Zahl1.");
            }
        }
    }
}



