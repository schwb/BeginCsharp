using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vererbung: 
          Erstelle eine Klasse Tier. Ein Tier hat einen Namen, Alter, Geschwindigkeit, Bool Hunger, 
          Methode GibLaut, Art, Methode Essen, Methode Bewegen,  
          Erstelle eine Klasse Hund, Katze, Maus die vom Tier erben. Überschreibe wenn nötig die ein oder  andere Methode. */
            Hund Hund = new Hund("Michael");
            Hund.Alter = 12;
            Hund.Geschwindigkeit = "schnell";
            Hund.Hunger = true;
            Hund.Art = "Schäferhund";
            Hund.Tiergeräusch = "Wauwau";
            Console.WriteLine($"Der {Hund.Art} {Hund.Name} ist {Hund.Alter} Jahre alt und ruft laut {Hund.GibLaut()}. {Hund.bewegen()} und {Hund.Essen()}.");
            Maus Maus = new Maus("Ilse");
            Maus.Alter = 5;
            Maus.Geschwindigkeit = "rasend";
            Maus.Hunger = false;
            Maus.Art = "Spitzmaus";
            Maus.Tiergeräusch = "Pipspips";
            Console.WriteLine($"Die {Maus.Art} {Maus.Name} ist {Maus.Alter} Jahre alt und ruft laut {Maus.GibLaut()}. {Maus.bewegen()} und {Maus.Essen()}.");
            Katze Katze = new Katze("Mischell");
            Katze.Alter = 8;
            Katze.Geschwindigkeit = "gemächlich";
            Katze.Hunger = true;
            Katze.Art = "Wildkatze";
            Katze.Tiergeräusch = "Miau";
            Console.WriteLine($"Die {Katze.Art} {Katze.Name} ist {Katze.Alter} Jahre alt und ruft laut {Katze.GibLaut()}. {Katze.bewegen()} und {Katze.Essen()}.");
            //Hier wird Linq verwendet. Die Methoden für Listen, die hier neu sind sind Where und Select.
            List<Tier>animals=new List <Tier> ();
            animals.Add(Hund);
            animals.Add(Katze);
            animals.Add(Maus);
            List<Tier> animals2 = animals.Where(w => w.Hunger == true).Select(s => s).ToList();
            foreach(Tier z in animals2)
            {
                //Hierdurch werden die Klassennamen ausgegeben. Dies macht der Befehl: .GetType().Name.
                Console.WriteLine($"Das Tier ist ein/e {z.GetType().Name}");
            }
        }
    }
}


