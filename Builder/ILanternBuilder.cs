using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ILanternBuilder
    {
        void BuildHousing();
        void BuildLightSource();
        void BuildHandle();
        Lantern GetLantern();
    }
}
