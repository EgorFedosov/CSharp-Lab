namespace SmartHomeSystem.SmartLight
{

    public class RgbLight : BasicLight
    {
        public enum LightColor
        {
            White,
            Red,
            MutedYellow,
            Blue,
            Pink
        };

        private LightColor _color;
        public LightColor Color { get; set; }

        public RgbLight() : base()
        {
            Type = LightType.RgbLight;
            Color = LightColor.White;
        }

        public void SetStatus(LightStatus status, LightColor color)
        {
            base.SetStatus(LightStatus.On);
            SetLightColor(color);
        }

        public void SetLightColor(LightColor color)
        {
            Color = color;
        }
    }

}