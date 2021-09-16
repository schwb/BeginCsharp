using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine zeichenfolge ein.");
            string a = Console.ReadLine();
            Console.WriteLine("Ab wo soll der Substring starten?");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bis wohin soll der Substring gehen?");
            int c = Convert.ToInt32(Console.ReadLine());
            string d = a.Substring(b, c);
            Console.WriteLine(d);
        }
    }
}



