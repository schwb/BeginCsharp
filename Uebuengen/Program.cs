using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie einen Text ein");
            string first = Console.ReadLine();
            string s = first.ToLower();
                string b = first.ToUpper();
                Console.WriteLine(s + b);
        }
    }
}
