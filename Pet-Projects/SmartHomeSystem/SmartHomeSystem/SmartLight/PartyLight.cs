namespace SmartHomeSystem.SmartLight
{

    public class PartyLight : RgbLight
    {
        public enum DiscoLight
        {
            On,
            Off
        };
        
        public DiscoLight Disco { get; set; }

        public PartyLight() : base()
        {
            Type = LightType.PartyLight;
            Disco = DiscoLight.Off;
        }
        
        public void SetStatus(LightStatus status, LightColor color, DiscoLight discoLight)
        {
            base.SetStatus(status, color);
            SetDiscoMode(true);
        }
        
        public void SetDiscoMode(bool isDisco)
        {
            Disco = isDisco ? DiscoLight.On : DiscoLight.Off;
        }
    }

}