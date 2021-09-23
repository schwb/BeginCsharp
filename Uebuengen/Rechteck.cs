using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    class Rechteck
    {
        public double Seitenlänge1 { get; set; }
        public double Seitenlänge2 { get; set; }
        public double Umfang(double Seitenlänge1, double Seitenlänge2)
        {
            return (2 * (Seitenlänge1 + Seitenlänge2));
        }
        public double Fläche(double Seitenlänge1, double Seitenlänge2)
        {
            return (Seitenlänge1* Seitenlänge2);
        }
        public override string ToString()
        {
            return $"Das Rechteck hat den Umfang {Umfang(Seitenlänge1,Seitenlänge2)} und den Flächeninhalt {Fläche(Seitenlänge1,Seitenlänge2)}.";
        }

    }
}
