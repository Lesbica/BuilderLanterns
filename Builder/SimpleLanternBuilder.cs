using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SimpleLanternBuilder : ILanternBuilder
    {
        private Lantern lantern = new Lantern();

        public void BuildHousing()
        {
            lantern.Housing = "Plastic";
        }

        public void BuildLightSource()
        {
            lantern.LightSource = "LED";
        }

        public void BuildHandle()
        {
            lantern.Handle = "Plastic handle";
        }

        public Lantern GetLantern()
        {
            return lantern;
        }
    }
}
