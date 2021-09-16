using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Einträge möchten Sie im Array haben?");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];
            for(int c = 0; c < b.Length; c++)
            {
                Console.WriteLine("Welche Zahl soll nun eingetragen werden?");
                b[c] = Convert.ToInt32(Console.ReadLine());
            }
            for (int c = 0; c < b.Length; c++)
            {
                Console.WriteLine(b[c]);
            }
        }
    }
}



