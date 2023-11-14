namespace Builder
{
    public class LanternDirector
    {
        public Lantern Construct(ILanternBuilder builder)
        {
            builder.BuildHousing();
            builder.BuildLightSource();
            builder.BuildHandle();
            return builder.GetLantern();
        }
    }
}