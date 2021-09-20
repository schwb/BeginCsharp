using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Einträge möchtest du?");
            int Einträge = Convert.ToInt32(Console.ReadLine());
            string[] Wörter = new string[Einträge];
            for (int Index = 0; Index < Wörter.Length; Index++)
            {
                Console.WriteLine("Bitte tippe einen namen ein.");
                Wörter[Index] = Console.ReadLine();
            }
            string Konkateniert = string.Join(';' , Wörter);
            Console.WriteLine($"Die Namen lauten: {Konkateniert}.");
            double[] Zahlen = new double[Einträge];
            for (int Index =0; Index<Zahlen.Length; Index++)
            {
                Console.WriteLine("bitte gib eine zahl ein.");
                int zahl = Convert.ToInt32(Console.ReadLine());
                Zahlen[Index] = zahl;
            }
            int Inhalt = 0;
            double summe = 0;
            while (Inhalt < Zahlen.Length)
            {
                double Zahl1 = Zahlen[Inhalt];
                summe += Zahl1;
                Inhalt++;
            }
            double Durchschnitt = summe / Einträge;
            Console.WriteLine($"Die Summe der Zahlen lautet: {summe} und der Durchschnitt lautet: {Durchschnitt}.");
        }
    }
}



