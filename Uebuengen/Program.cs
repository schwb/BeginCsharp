using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random k = new Random();
            Console.WriteLine("Wie viel $ besitzen sie?");
            int Besitz1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Was ist ihr erster Einsatz?");
            int Einsatz = Convert.ToInt32(Console.ReadLine());
            int Gewinn = 0;
            int AnzahlS = 1;
            int Besitz = Besitz1;
            bool weiterspielen = true;
            while (Besitz > 0 && weiterspielen)
            {
                Besitz -= Einsatz;

                int Zahl = k.Next(0, 36);

                if (Zahl != 0 && Zahl % 2 == 0)
                {
                    Besitz = Besitz + 2 * Einsatz;
                    Gewinn = 1;
                }
                else if (Zahl == 0)
                {
                    //Besitz = Besitz;
                    Gewinn = 0;
                }
                else
                {
                    //Besitz = Besitz1 - Einsatz;
                    Gewinn = 0;
                }
                Console.WriteLine($"Anzahl des Spiels: {AnzahlS}, Geworfene Zahl: {Zahl}, Dein Einsatz: {Einsatz}, Kapital davor: {Besitz1}, Kapital danach: {Besitz}");
                Besitz1 = Besitz;

                AnzahlS++;
                if (Besitz >= 10000 && Gewinn == 1)
                {
                    Einsatz = 10;
                }
                if (Besitz >= 10000 && Gewinn == 0)
                {
                    Einsatz = Einsatz * 2;
                }
                else if (Besitz < 10000 && Einsatz * 2 <= Besitz)
                {
                    Einsatz = 10000 - Besitz;
                    Einsatz = Einsatz * 2;
                    if (Einsatz > Besitz)
                    {
                        Einsatz = Besitz;
                    }
                }
                else if (Besitz < 10000 && Besitz > 1000)
                {
                    Einsatz = 1000;
                }
                else if (Besitz <= 1000)
                {
                    Einsatz = Besitz;
                }
                Console.WriteLine("Möchten sie nochmal spielen? (ja, nein)");
                if (Console.ReadLine() == "ja")
                {
                    weiterspielen = true;
                }
                else
                {
                    weiterspielen = false;
                }
                if (Einsatz > 1000)
                {
                    Einsatz = 1000;
                }
            }
            Console.WriteLine($"Da Sie kein Kapital mehr haben, können Sie nicht weiterspielen!");
        }
    }
}



