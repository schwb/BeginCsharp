using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie einen Text ein");
            string first = Console.ReadLine();
            bool val = first.Equals("abcde");
            Console.WriteLine(val);
        }
    }
}
