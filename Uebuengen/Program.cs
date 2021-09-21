using System;
using System.Collections.Generic;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib den Nenner des Bruchs ein.");
            double Zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib den Zähler des Bruchs ein.");
            double Zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte wähle eine Rechenmethode für den Bruch.");
            string Rechenmethode = Console.ReadLine();
            double Ergebnis = 0;
            switch(Rechenmethode)
            {
                case "Negieren":
                    Ergebnis = Negieren(Zahl2, Zahl1);
                    break;
                case "Umkehren":
                    Ergebnis = Umkehren(Zahl2, Zahl1);
                    break;
                case "Erweitern":
                    Console.WriteLine("Um welchen Faktor möchtest du den Bruch erweitern?");
                    double Faktor = Convert.ToDouble(Console.ReadLine());
                    Ergebnis = Erweitern(Zahl2, Zahl1, Faktor);
                    break;
                default:
                    Console.WriteLine("Deine gewählte Methode ist in diesem Programm nicht definiert.");
                    break;
            }
            Console.WriteLine($"Das Ergebnis lautet {Ergebnis}.");
        }
        static double Negieren(double Zahl2, double Zahl1)
        {
            Zahl1 = Zahl1 * -1;
            return (Zahl1 / Zahl2);
        }
        static double Umkehren(double Zahl2, double Zahl1)
        {
            return (Zahl2 / Zahl1);
        }
        static double Erweitern(double zahl2, double zahl1, double faktor)
        {
            zahl1 = zahl1 * faktor;
            zahl2 = zahl2 * faktor;
            return (zahl1 / zahl2);
        }
        static double Ggt(double zahl2, double zahl1)
        {

        }
    }
}



