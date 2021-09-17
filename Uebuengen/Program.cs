using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib die ISBN-Nummer ein.");
            string Nummer1 = Console.ReadLine();
            string nummer = Nummer1.Replace("-","").Replace(" ","");
            int a = 10;
            int c = 0;
            for (int Index=0; Index<nummer.Length-1; Index++)
            {
                int z = Convert.ToInt32(nummer[Index]);
                int b = z * a;
                a -= 1;
                c += b;
            }
            int x = Convert.ToInt32(nummer[9]);
            if ((c + x) % 11 == 0)
            {
                Console.WriteLine($"Diese Nummer ist {(c + x) / 11} *11, also ist sie eine gültige ISBN-Nummer.");
            }
            else
            {
                Console.WriteLine("Diese Nummer ist keine gültige ISBN-Nummer.");
            }
        }
    }
}



