namespace SmartHomeSystem.SmartLight
{

    public class RgbLight: BasicLight
    {
        public enum LightColor
        {
            White,
            Red,
            Blue,
            Pink,
        };

        private LightColor _color;
        public LightColor Color { get; set; }
         
        public RgbLight(): base()
        {
            this.Type = LightType.RgbLight;
            this.Color = LightColor.White;
        }

        public void SetLightColor(LightColor color)
        {
            this.Color = color;
        }
    }

}