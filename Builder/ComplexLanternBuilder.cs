using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ComplexLanternBuilder : ILanternBuilder
    {
        private Lantern lantern = new Lantern();

        public void BuildHousing()
        {
            lantern.Housing = "Metal";
        }

        public void BuildLightSource()
        {
            lantern.LightSource = "Incandescent bulb";
        }

        public void BuildHandle()
        {
            lantern.Handle = "Metal handle with rubber grip";
        }

        public Lantern GetLantern()
        {
            return lantern;
        }
    }
}
