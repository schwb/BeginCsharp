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
            int max = b[0];
            for(int c = 0; c < b.Length; c++)
            {
                if (max < b[c])
                {
                    max = b[c];
                }
            }
            Console.WriteLine("Maximum ist " + max);
            int min = b[0];
            for(int c =0;c<b.Length; c++)
            {
                if (min > b[c])
                {
                    min = b[c];
                }
            }
            Console.WriteLine("Minimum ist " + min);
            double summe = 0;
            for(int c=0;c<b.Length; c++)
            {
                summe = summe + b[c];
            }
            Console.WriteLine("Der Durchschnitt ist " + (summe / a));
        }
    }
}



