using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LanternBuilderDirector
    {
        private LanternBuilder builder = new LanternBuilder();

        public void BuildBase(string imagePath)
        {
            builder.BuildBase(imagePath);
        }

        public void BuildBulb(string imagePath)
        {
            builder.BuildBulb(imagePath);
        }

        public void BuildStand(string imagePath)
        {
            builder.BuildStand(imagePath);
        }

        public Lantern GetLantern()
        {
            return builder.GetLantern();
        }
    }
}
