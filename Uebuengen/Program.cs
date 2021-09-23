using System;
using System.Collections.Generic;
using System.IO;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        { 
            Dreieck Dreieck1 = new Dreieck();
            Dreieck1.Seite1 = 7.07;
            Dreieck1.Seite2 = 7.07;
            Dreieck1.Seite3 = 10;
            Dreieck1.Basis = 10;
            Dreieck1.Höhe = 5;
            Dreieck1.Name = "Dreieck";
            Quadrat Quadrat1 = new Quadrat();
            Console.WriteLine("Welche Seitenlänge hat dein Quadrat?");
            Quadrat1.Seitenlänge = Convert.ToDouble(Console.ReadLine());
            Quadrat1.Name = "Quadrat";
            Rechteck Rechteck1 = new Rechteck();
            Console.WriteLine("Wie lang ist Seite1 des Rechtecks?");
            Rechteck1.Seitenlänge1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wie lang ist Seite2 des Rechtecks?");
            Rechteck1.Seitenlänge2 = Convert.ToDouble(Console.ReadLine());
            Rechteck1.Name = "Rechteck";
            /*Erstelle in Interface mit dem Namen IGraphicObjects. Dieses Interface soll zwei Methoden definieren. 
             * Umfang und Flaeche.
            Deine bereits erstellen Klassen Quadrat, 
            Rechteck und Dreieck sollen das Interface IGraphicObjects implementieren. 
            Erstelle in deiner Programm.cs eine Liste Zeichenflaeche in welche alle Quadrate, 
            Rechtecke und Dreiecke gemeinsam gespeichert werden können.Gebe dann den Umfang 
            und die Fläche der jeweiligen Objekte in einer Foreach Schleife aus.*/ 
            List<IGraphicObjects> Zeichenfläche = new List<IGraphicObjects>();
            Zeichenfläche.Add(Dreieck1);
            Zeichenfläche.Add(Quadrat1);
            Zeichenfläche.Add(Rechteck1);
            foreach(IGraphicObjects Ergebnis in Zeichenfläche)
            {
                Console.WriteLine(Ergebnis.ToString());
                //andere Möglichkeit den Text auszugeben. Hier beachten, dass man Name auch zum Interface hinzufügen muss.
                Console.WriteLine($"Das {Ergebnis.Name} hat den Umfang {Ergebnis.Umfang()} und den Flächeninhalt {Ergebnis.Fläche()}.");
            }
        }
    }
}


