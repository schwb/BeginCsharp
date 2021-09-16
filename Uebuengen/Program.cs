using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein.");
            int a = Convert.ToInt32(Console.ReadLine());
            int Tage = a / (360 * 24);
            int Stunden = (a - (Tage * 360 * 24))/360;
            int Minuten = (a - (Tage * 360 * 24) - (Stunden * 360)) / 60;
            int Sekunden = (a - (Tage * 360 * 24) - (Stunden * 360) - (Minuten * 60));
            Console.WriteLine($"Tage: {Tage}, Stunden: {Stunden}, Minuten: {Minuten}, Sekunden: {Sekunden}");
        }
    }
}



