using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein.");
            double Zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib eine Zahl ein.");
            double Zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib einen Operator ein. (+-*/%)");
            string Operator = Console.ReadLine();
            double ergebnis = 0;
            switch (Operator)
            {
                case "+":
                    ergebnis = Zahl1 + Zahl2;
                    break;
                case "-":
                    ergebnis = Zahl1 - Zahl2;
                    break;
                case "/":
                    ergebnis = Zahl1 / Zahl2;
                    break;
                case "*":
                    ergebnis =  Zahl1* Zahl2;
                    break;
                case "%":
                    ergebnis = Zahl1 % Zahl2;
                    break;
                default:
                    Console.WriteLine("Der von Dir eingegebene Operator ist nicht definiert");
                    break;
            }
            Console.WriteLine($"Das Ergebnis deiner Rechnung ist {ergebnis}.");
        }
    }
}



