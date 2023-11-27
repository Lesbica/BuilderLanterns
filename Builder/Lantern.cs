using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Prototype;

namespace Builder
{
    public class Lantern
    {
        public string BaseImage { get; set; }
        public string BulbImage { get; set; }
        public string StandImage { get; set; }
        // Додаткові властивості для інших частин ліхтаря

        public override string ToString()
        {
            return $"Lantern: Base - {BaseImage}, Bulb - {BulbImage}, Stand - {StandImage}";
        }
    }
}
