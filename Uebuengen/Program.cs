using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie Zahl eins Ihrer Addition ein.");
            int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben sie Zahl zwei ihrer Addition ein.");
            int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(first + second);
        }
    }
}
