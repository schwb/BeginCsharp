using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    class Quadrat
    {
        public double Seitenlänge { get; set; }
        public double Umfang(double Seitenlänge)
        {
            return (4 * Seitenlänge);
        }
        public double Fläche(double Seitenlänge)
        {
            return (Seitenlänge * Seitenlänge);
        }
        public override string ToString()
        {
            return $"Das Quadrat hat den Umfang {Umfang(Seitenlänge)} und den Flächeninhalt {Fläche(Seitenlänge)}.";
        }
    }
}
