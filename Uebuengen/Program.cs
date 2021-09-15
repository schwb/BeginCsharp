using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie einen Text ein");
            string first = Console.ReadLine();
            char[] MyChar = {' '};
            string newstring = first.Trim();
            Console.WriteLine(newstring);
        }
    }
}
