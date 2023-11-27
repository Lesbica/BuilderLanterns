using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Prototype
{
    public class LanternPrototype
    {
        public string BaseImage { get; set; }
        public string BulbImage { get; set; }
        public string StandImage { get; set; }

        public LanternPrototype Clone()
        {
            return MemberwiseClone() as LanternPrototype;
        }
    }
}
