using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LanternBuilder : ILanternBuilder
    {
        private Lantern lantern = new Lantern();

        public void BuildBase(string imagePath)
        {
            lantern.BaseImage = imagePath;
        }

        public void BuildBulb(string imagePath)
        {
            lantern.BulbImage = imagePath;
        }

        public void BuildStand(string imagePath)
        {
            lantern.StandImage = imagePath;
        }

        public Lantern GetLantern()
        {
            return lantern;
        }

        public LanternPrototype GetPrototype()
        {
            return new LanternPrototype
            {
                BaseImage = lantern.BaseImage,
                BulbImage = lantern.BulbImage,
                StandImage = lantern.StandImage
            };
        }
    }
}
