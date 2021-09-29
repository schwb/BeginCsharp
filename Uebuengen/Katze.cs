using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    /// <summary>
    /// Das ist die Klasse "Katze".
    /// </summary>
    class Katze : Tier
    {
        /// <summary>
        /// Construcktor takes param "Tiername" to set "name".
        /// </summary>
        /// <param name="Tiername"></param>
        public Katze(string Tiername) : base(Tiername)
        {

        }
        /// <summary>
        /// If property Hunger is true, than puts out "frisst sich an einer saftigen Maus satt, die sie bei der Jagt erlegt hat", else puts out "{Name} isst nichts.".
        /// </summary>
        /// <returns></returns>
        public override /*durch den Befehl override wird die Methode Essen überschrieben.*/ string Essen()
        {
            if (Hunger == true)
            {
                return ($"frisst sich an einer saftigen Maus satt, die sie bei der Jagt erlegt hat");
            }
            else
            {
                return ($"{Name} isst nichts.");
            }
        }
    }
}
