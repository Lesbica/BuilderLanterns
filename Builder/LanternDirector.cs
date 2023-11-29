namespace Builder
{
    public class LanternDirector
    {
        private ILanternBuilder builder;

        public ILanternBuilder Builder
        {
            set { builder = value; }
        }

        public void ConstructLantern(string baseImage, string bulbImage, string standImage)
        {
            builder.BuildBase(baseImage);
            builder.BuildBulb(bulbImage);
            builder.BuildStand(standImage);
        }

        public Lantern GetConstructedLantern()
        {
            return builder.GetLantern();
        }
    }
}