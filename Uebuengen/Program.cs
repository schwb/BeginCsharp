using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie ist dein Name?");
            string a = Console.ReadLine();
            bool b = string.IsNullOrEmpty(a);
            while(b)
            {
                Console.WriteLine("Hast du keinen Namen?");
                a = Console.ReadLine();
                b = string.IsNullOrEmpty(a);
            }
            int summe1 = 0;
            for(int c = 0; c < a.Length; c++)
            {
                char u = a[c];
                if (u.Equals('a'))
                {
                    summe1 = summe1 + 1;
                }
                if (u.Equals('A'))
                {
                    summe1 = summe1 + 1;
                }
            }
            Console.WriteLine("Der Buchstabe A/a ist im eingegebenen Wort " + summe1 + "mal enthalten.");
            Console.WriteLine("Bitte geben sie eine Zahl ein.");

        }
    }
}



