using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    public class Quadrat : IGraphicObjects//Hierdurch wird das Interface IGraphicobjects
                                          //in der Klasse Quadrat implementiert.
    {
        public double Seitenlänge { get; set; }
        public string Name { get; set; }
        public double Umfang()
        {
            return 4 * Seitenlänge;
        }
        public double Fläche()
        {
            return Seitenlänge * Seitenlänge;
        }
        public override string ToString()
        {
            //So gibt man den Text innerhalb der Klasse aus. ToString muss dann nur noch aufgerufen werden, um Text auszugeben.
            return $"Das Quadrat hat den Umfang {Umfang()} und den Flächeninhalt {Fläche()}.";
        }
    }
}
