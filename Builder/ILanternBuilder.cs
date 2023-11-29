using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ILanternBuilder
    {
        void BuildBase(string imagePath);
        void BuildBulb(string imagePath);
        void BuildStand(string imagePath);
        Lantern GetLantern();
    }
}
