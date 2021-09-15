using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ab wo soll runter gezählt werden?");
            int var = Convert.ToInt32(Console.ReadLine());
            for (int index = var; index >= 0; index -= 1)
                Console.WriteLine(index);
        }
    }
}
