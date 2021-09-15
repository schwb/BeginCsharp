using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie einen Text ein");
            string first = Console.ReadLine();
            first = first.PadLeft(20, 'y');
            Console.WriteLine(first);
        }
    }
}
