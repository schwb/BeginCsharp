using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    class universal_fish
    {
        public virtual string appearancefishleft { get; set; }
        public virtual string appearancefishright { get; set; }
        public int appearheight { get; set; }
        public int appearbroad { get; set; }
        public string leftright { get; set; }
        public int maxheight { get; set; }
        public virtual void schwimmtiefe()
        {
        }

    }
}
