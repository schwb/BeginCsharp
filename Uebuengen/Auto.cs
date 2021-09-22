using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    class Auto
    {
        public Auto(string Name) //Constructor(kann nur im Constructor verändert werden und nicht mit Auto. ...)
        {
            Modell = Name;
        }
        public string Modell;
        public int Räder;
        public int Türen;
        public string Farbe;
    }
    
}
