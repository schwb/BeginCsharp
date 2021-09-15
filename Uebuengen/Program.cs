using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            Console.WriteLine("Bis wohin soll gezählt werden?");
            int var = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index <= var; index += 1) 
            {
                summe = summe + index;
                Console.WriteLine(summe);
            }
        }
    }
}
