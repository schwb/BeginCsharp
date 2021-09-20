using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random k1 = new Random();
            int Zahl1 = k1.Next(0, 36);
            Console.WriteLine("Wie viel $ besitzen sie?");
            int Besitz1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Was ist ihr erster Einsatz?");
            int Einsatz = Convert.ToInt32(Console.ReadLine());
            int Gewinn = 0;
            int AnzahlS = 1;
            int Besitz = Besitz1;
            int a = 0;
            int Zahl = Zahl1;
            while(Besitz>0 && a==0)
            {
            if (Zahl != 0 && Zahl % 2 == 0)
            {
                Besitz = Besitz1 + 2 * Einsatz;
                Gewinn = 1;
            }
            else if (Zahl == 0)
            {
                Besitz = Besitz1;
                    Gewinn = 0;
            }
            else
            {
                Besitz = Besitz1 - Einsatz;
                    Gewinn = 0;
            }
            Console.WriteLine($"Anzahl des Spiels: {AnzahlS}, Geworfene Zahl: {Zahl}, Dein Einsatz: {Einsatz}, Kapital davor: {Besitz1}, Kapital danach: {Besitz}");
                Random k = new Random();
                Zahl = k.Next(0, 36);
                AnzahlS++;
                if (Besitz >= 10000 && Gewinn == 1)
                {
                    Einsatz = 10;
                }
                if (Besitz >= 10000 && Gewinn == 0)
                {
                    Einsatz = Einsatz * 2;
                }
                else if (Besitz <10000 && Einsatz * 2 <= Besitz)
                {
                    Einsatz = 10000 - Besitz;
                    Einsatz = Einsatz * 2;
                    if(Einsatz>Besitz)
                    {
                        Einsatz = Besitz;
                    }
                }
                else if (Besitz < 10000 && Besitz > 1000)
                {
                    Einsatz = 1000;
                }
                else if (Besitz <=1000)
                {
                    Einsatz = Besitz;
                }
                Console.WriteLine("Möchten sie nochmal spielen? (ja, nein)");
                if(Console.ReadLine()=="ja")
                {
                    a = 0;
                }
                else
                {
                    a = 1;
                }
                Besitz1 = Besitz;
                if (Einsatz>1000)
                {
                    Einsatz = 1000;
                }
            }
            Console.WriteLine($"Da Sie kein Kapital mehr haben, können Sie nicht weiterspielen!");
        }
    }
}



