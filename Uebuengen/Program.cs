using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie einen Text ein");
            string first = Console.ReadLine();
            bool third = first.Contains("abc");
            Console.WriteLine(third);
        }
    }
}
