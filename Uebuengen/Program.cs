using System;
using System.Collections.Generic;
using System.IO;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Ford = new Auto("Ford");
            Ford.Räder = 4;
            Ford.Türen = 3;
            Ford.Farbe = "schwarz";
            Console.WriteLine($"Das Auto namens {Ford.Modell} hat {Ford.Räder} Räder, {Ford.Türen} Türen und ist {Ford.Farbe} lackiert.");
        }
    }
}


