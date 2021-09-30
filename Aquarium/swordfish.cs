using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquariumproject
{
    class swordfish: universal_fish
    {
        public override string appearancefishleft { get; set; } = "-<><";
        public override string appearancefishright { get; set; } = "><>-";
        public override void schwimmtiefe()
        {
            Random r = new Random();
            int highlow = r.Next(0, 99);
            int probability = r.Next(1, 100);
            if (probability < 21)
            {
                if (highlow % 2 == 0)
                {
                    if (appearheight < 2)
                    {
                    }
                    else
                    {
                        appearheight = appearheight - 1;
                    }
                }
                else
                {
                    if (appearheight == (maxheight - 2))
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
