using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[] { 10, 20, 98, 50, 1, 70 };
            Console.WriteLine("Die Werte des Arrays:");
            for (int Index = 0; Index < zahlen.Length; Index++)
            {
                Console.WriteLine(zahlen[Index]);
            }
            Console.WriteLine("Die Werte des Arrays rückwärts:");
            for (int Index = zahlen.Length - 1; Index >= 0; Index--)
            {
                Console.WriteLine(zahlen[Index]);
            }
            Console.WriteLine("Die Werte in sortierter Reihenfolge:");
            int position = 0;
            while (position < zahlen.Length - 1)
            {
                if (zahlen[position] > zahlen[position + 1])
                {
                    int swap = zahlen[position];
                    zahlen[position] = zahlen[position + 1];
                    zahlen[position + 1] = swap;
                    position = 0;
                }
                else
                {
                    position++;
                }
            }



            Console.WriteLine(string.Join(",", zahlen));
        }
    }
}



