using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    /// <summary>
    /// This is the base class for all animals.
    /// </summary>
    class Tier
    {
        /// <summary>
        /// This is the base param for all names.
        /// </summary>
        /// <param name="Tiername"></param>
        public Tier(string Tiername)
            {
            Name = Tiername;
            } 
        /// <summary>
        /// This property is set by the param
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This property stands for the age of the animal.
        /// </summary>
        public int Alter { get; set; }
        /// <summary>
        /// This describes the speed of the animal.
        /// </summary>
        public string Geschwindigkeit { get; set; }
        /// <summary>
        /// Describes if the animal is hungry
        /// </summary>
        public bool Hunger { get; set; }
        /// <summary>
        /// Stands for the kind of the animal.
        /// </summary>
        public string Art { get; set; }
        /// <summary>
        /// Describes the animal signs
        /// </summary>
        public string Tiergeräusch { get; set; }
        /// <summary>
        /// Takes the property "Tiergeräusch" and returns it.
        /// </summary>
        /// <returns></returns>
        public string GibLaut()
        {
            return Tiergeräusch;
        }
        /// <summary>
        /// If property Hunger is true, than puts out "frisst sich satt", else puts out "isst daher auch nichts".
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Takes property "Geschwindigkeit" and returns "bewegt sich {Geschwindigkeit} fort"
        /// </summary>
        /// <returns></returns>
        public virtual string bewegen()
        {
            return $"{Name} bewegt sich {Geschwindigkeit} fort";
        }
    }
}
