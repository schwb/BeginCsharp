using System;
using System.Collections.Generic;
using System.IO;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was möchtest du berechnen? (Umfang Kreis, Umfang Quadrat, umfang Rechteck, Volumen Würfel, Volumen Quader)");
            string Methode = Console.ReadLine();
            switch (Methode)
            {
                case "Umfang Kreis":
                    Console.WriteLine("Wie lautet der Durchmesser des Kreises?");
                    double Durchmesser = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Der Umfang des Kreises lautet {UmfangKreis(Durchmesser)}");
                    break;
                case "Umfang Quadrat":
                    Console.WriteLine("Wie lang sind die Seiten des Quadrats?");
                    double Seitenlänge = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Der Umfang des Quadrats lautet { UmfangQuadrat(Seitenlänge)}.");
                    break;
                case "Umfang Rechteck":
                    Console.WriteLine("Wie lautet Seitenlänge1?");
                    double Seitenlänge1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Wie lautet Seitenlänge2?");
                    double Seitenlänge2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Der Umfang des Rechtecks lautet {UmfangRechteck(Seitenlänge1, Seitenlänge2)}.");
                    break;
                case "Volumen Würfel":
                    Console.WriteLine("Wie lautet die Seitenlänge des Würfels?");
                    double Seitenlänge3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Das Volumen des Würfels lautet {VolumenWürfel(Seitenlänge3)}.");
                    break;
                case "Volumen Quader":
                    Console.WriteLine("Wie lang ist Seite eins?");
                    double Seitenlänge4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Wie lang ist Seite zwei?");
                    double Seitenlänge5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Wie hoch ist der Quader?");
                    double Höhe = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Der Quader hat das Volumen {VolumenQuader(Seitenlänge4, Seitenlänge5, Höhe)}.");
                    break;
                default:
                    Console.WriteLine("Deine Eingabe ist nicht definiert.");
                    break;
            }
        }
        static double UmfangKreis(double Durchmesser)
        {
            return (Math.PI * Durchmesser);
        }
        static double UmfangQuadrat(double Seitenlänge)
        {
            return (4 * Seitenlänge);
        }
        static double UmfangRechteck(double Seitenlänge1,double Seitenlänge2)
        {
            return (2 * Seitenlänge1 + 2 * Seitenlänge2);
        }
        static double VolumenWürfel(double Seitenlänge)
        {
            return (Math.Pow(Seitenlänge, 3));
        }
        static double VolumenQuader(double Seitenlänge1, double Seitenlänge2, double Höhe)
        {
            return (Seitenlänge1 * Seitenlänge2 * Höhe);
        }
    }
}


