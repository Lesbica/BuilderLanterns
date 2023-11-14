using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Lantern
    {
        public string Housing { get; set; }
        public string LightSource { get; set; }
        public string Handle { get; set; }

        public string Display()
        {
            return ($"Housing: {Housing}, Light Source: {LightSource}, Handle: {Handle}");
        }
    }
}
