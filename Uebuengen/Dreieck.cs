using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    class Dreieck
    {
        public double Seite1 { get; set; }
        public double Seite2 { get; set; }
        public double Seite3 { get; set; }
        public double Basis { get; set; }
        public double Höhe { get; set; }
        public double Umfang(double Seite1, double Seite2, double Seite3)
        {
            return (Seite1 + Seite2 + Seite3);
        }
        public double Fläche(double Basis,double Höhe)
        {
            return (Basis*Höhe/2);
        }
        public override string ToString()
        {
            return $"Das Dreieck hat den Umfang {Umfang(Seite1, Seite2, Seite3)} und den Flächeninhalt {Fläche(Basis, Höhe)}";
        }
    }
}
