using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    class Tier
    {
        public Tier(string Tiername)
            {
            Name = Tiername;
            } 
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Geschwindigkeit { get; set; }
        public bool Hunger { get; set; }
        public string Art { get; set; }
        public string Tiergeräusch { get; set; }
        public string GibLaut()
        {
            return Tiergeräusch;
        }
        public virtual /*durch virtual kann in den anderen Klassen die Methode Essen überschrieben werden. */ string Essen()
        {
            if(Hunger==true)
            {
                return ($"frisst sich satt");
            }
            else
            {
                return ($"isst daher auch nichts");
            }
        }
        public virtual string bewegen()
        {
            return $"{Name} bewegt sich {Geschwindigkeit} fort";
        }
    }
}
