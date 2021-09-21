using System;
using System.Collections.Generic;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein.");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib eine Zahl ein.");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib eine Rechenoperation ein. (+,-,*,/)");
            string Operant = Console.ReadLine();
            switch (Operant)
            {
                case "+":
                    int Ergebnis = Addition(Zahl1, Zahl2);
                    Console.WriteLine($"Das Ergebnis deiner Addition lautet: {Ergebnis}.");
                    break;
                case "-":
                    Ergebnis = Subtraktion(Zahl1, Zahl2);
                    Console.WriteLine($"Das Ergebnis deiner Subtraktion lautet: {Ergebnis}.");
                    break;
                case "*":
                    Ergebnis = Multiplikation(Zahl1, Zahl2);
                    Console.WriteLine($"Das Ergebnis deiner Multiplikation lautet: {Ergebnis}");
                    break;
                case "/":
                    Ergebnis = Division(Zahl1, Zahl2);
                    Console.WriteLine($"Das Ergebnis deiner Division lautet: {Ergebnis}.");
                    break;
                default:
                    Console.WriteLine("Der von dir eingegebene Operator ist nicht definiert");
                    break;
            }
        }
        static int Addition (int egal, int auchegal)
        {
            int a = egal + auchegal;
            return (a);
        }
        static int Subtraktion (int egal, int auchegal)
        {
            int a = egal - auchegal;
            return (a);
        }
        static int Multiplikation(int egal, int auchegal)
        {
            int a = egal * auchegal;
            return (a);
        }
        static int Division(int egal, int auchegal)
        {
            return (egal / auchegal);
        }
    }
}



