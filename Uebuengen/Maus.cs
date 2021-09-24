using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    /// <summary>
    /// Das ist die Klasse "Maus".
    /// </summary>
    class Maus : Tier
    {
        /// <summary>
        /// Construcktor takes param "Tiername" to set "name".
        /// </summary>
        /// <param name="Tiername"></param>
        public Maus(string Tiername) : base(Tiername)
        {

        }
        public override string bewegen()
        {
            return $"{Name} bewegt sich {Geschwindigkeit} fort, da sie vor der hungrigen Katze auf der Flucht ist";
        }
    }
}
