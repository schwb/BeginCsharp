using System;
using System.Collections.Generic;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib ein, bis zu welcher Zahl aufsummiert werden soll.");
            int Eingabe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Die aufsummierten natürlichen Zahlen mit dem Ergebnis < {Eingabe} ergeben als Summe {maximumSum(Eingabe)}.");
        }
        static int maximumSum(int Eingabe)
        {
            if (Eingabe<0)
            {
                return 0;
            }
            else
            {
                int summe = 0;
                int Index = 0;
                for (Index=0;summe<Eingabe;Index++)
                {
                    summe += Index;
                }
                summe = summe - (Index-1);
                return summe;
            }
        }
    }
}



