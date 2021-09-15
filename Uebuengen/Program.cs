using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie einen Text ein.");
            string first = Console.ReadLine();
            int second = first.Length;
            Console.WriteLine("Die Länge des eingegebenen Textes ist");
                Console.WriteLine(second);
        }
    }
}
