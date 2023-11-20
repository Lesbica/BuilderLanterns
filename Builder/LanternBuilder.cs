using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LanternBuilder : ILanternBuilder
    {
        private Lantern _lantern = new Lantern();

        public void BuildHousing()
        {
            _lantern.AddPart("Housing");
        }

        public void BuildLightSource()
        {
            _lantern.AddPart("Light Source");
        }

        public void BuildHandle()
        {
            _lantern.AddPart("Handle");
        }

        public Lantern GetLantern()
        {
            Lantern result = _lantern;
            _lantern = new Lantern(); // Очищаємо будівельника для нового ліхтаря
            return result;
        }
    }
}
