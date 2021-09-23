using System;
using System.Collections.Generic;
using System.IO;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dreieck Eins = new Dreieck();
            Eins.Seite1 = 7.07;
            Eins.Seite2 = 7.07;
            Eins.Seite3 = 10;
            Eins.Basis = 10;
            Eins.Höhe = 5;
            Console.WriteLine(Eins.ToString());
            Quadrat Zwei = new Quadrat();
            Zwei.Seitenlänge = 10;
            Console.WriteLine(Zwei.ToString());
            Rechteck Drei = new Rechteck();
            Drei.Seitenlänge1 = 15;
            Drei.Seitenlänge2 = 25;
            Console.WriteLine(Drei.ToString());
        }
    }
}


