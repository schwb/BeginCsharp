using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    /// <summary>
    /// Das ist die Klasse "Hund".
    /// </summary>
    class Hund: Tier    
    {
        /// <summary>
        /// Construcktor takes param "Tiername" to set "name".
        /// </summary>
        /// <param name="Tiername"></param>
        public Hund(string Tiername): base(Tiername)
        {

        }
        /// <summary>
        /// Puts all methods and properties into a string and puts it as a complete text with added text out.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Der {Art} {Name} ist {Alter} Jahre alt und ruft laut {GibLaut()}. {bewegen()} und {Essen()}.";
        }
    }
}
