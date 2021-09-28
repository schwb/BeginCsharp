using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    class carp: universal_fish
    {
        public override string appearancefishleft { get; set; } = "<><";
        public override string appearancefishright { get; set; } = "><>";
        public override void schwimmtiefe()
        {
            Random r = new Random();
            int highlow = r.Next(0,99);
            int probability = r.Next(0,99);
            if (probability%2==0)
            {
                if (highlow % 2 == 0)
                {
                     if (appearheight == 0)
                    {
                    }
                     else
                    {
                        appearheight = appearheight - 1;
                    }
                }
                else
                {
                    if(appearheight == (maxheight-2))
                    {
                    }
                    else
                    {
                        appearheight = appearheight + 1;
                    }
                }
            }
        }
    }
}
