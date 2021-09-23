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
        public double Umfang()
        {
            return (2 * (Seitenlänge1 + Seitenlänge2));
        }
        public double Fläche()
        {
            return (Seitenlänge1* Seitenlänge2);
        }
        public override string ToString()
        {
            return $"Das Rechteck hat den Umfang {Umfang()} und den Flächeninhalt {Fläche()}.";
        }

    }
}
