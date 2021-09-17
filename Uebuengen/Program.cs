using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib ein wort ein:");
            string Wort = Console.ReadLine();
            string[] result = Wort.Split(new char[] { ',', ';', '!', '.', '?', '"', ' ' });
            Wort = string.Join("", result);
            Wort = Wort.ToLower();
            int f = Wort.Length - 1;
            int u = 0;
            for (int Index = 0; Index < Wort.Length/2 && u==0; Index++)
            {
                if (Wort[Index] == Wort[f])
                {
                    f -= 1;
                }
                else
                {
                    u = 1;
                    Console.WriteLine("Das Wort ist kein Palindrom.");
                }
            }
            if (u == 0)
            {
                Console.WriteLine("Das Wort ist ein Palindrom.");
            }
        }
    }
}



