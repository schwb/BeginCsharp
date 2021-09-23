using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebuengen
{
    interface IGraphicObjects
    {
        public double Umfang();
        public double Fläche();
        public string Name { get; set; }
    }
}
