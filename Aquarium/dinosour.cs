using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquariumproject
{
    class dinosour: universal_fish
    {
        public string appearancefishleft2 { get; set; } = "___o^_^_^_^_^_^_^--------";
        public string appearancefishleft1 { get; set; } = "  /                     ";
        public string appearancefishleft4 { get; set; } = "___o^_^_^_^_^_^_^--------";
        public string appearancefishleft3 { get; set; } = "  /                      ";
        public string appearancelefteating { get; set; } = "___o^_^_^_^_^_^_^--------";
        public string appearancefishright2 { get; set; } = "                       /";
        public string appearancefishright1 { get; set; } = "--------^_^_^_^_^_^_^o/___";
        public string appearancefishright4 { get; set; } = "                       /";
        public string appearancefishright3 { get; set; } = "--------^_^_^_^_^_^_^o/___";
        public string appearancerighteating { get; set; } = "--------^_^_^_^_^_^_^o___";
        public override void schwimmtiefe()
        {
            Random r = new Random();
            int highlow = r.Next(0, 99);
                if (highlow % 2 == 0)
                {
                    if (appearheight == 0 || appearheight == 1)
                    {
                    }
                    else
                    {
                        appearheight --;
                    }
                }
                else
                {
                    if (appearheight == (maxheight - 2))
                    {
                    }
                    else
                    {
                        appearheight ++;
                    }
                }
        }
    }
}
