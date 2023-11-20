namespace Builder
{
    public class LanternDirector
    {
        private ILanternBuilder _builder;

        public LanternDirector(ILanternBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructStandardLantern()
        {
            _builder.BuildHousing();
            _builder.BuildLightSource();
            _builder.BuildHandle();
        }

        public void ConstructCustomLantern()
        {
            _builder.BuildHousing();
            _builder.BuildHandle();
        }
    }
}