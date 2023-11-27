namespace Builder
{
    public class LanternDirector
    {
        private ILanternBuilder builder;

        public LanternDirector(ILanternBuilder builder)
        {
            this.builder = builder;
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