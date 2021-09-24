using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
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
    }
}
