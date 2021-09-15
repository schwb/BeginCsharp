using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie einen Text ein, der durch Semikolons in mehrere Abschnitte geteilt ist.");
            string first = Console.ReadLine();
            string[] second = first.Split(';');
            Console.WriteLine(second[0]);
            Console.WriteLine(second[1]);
        }
    }
}
