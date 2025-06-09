namespace SmartHomeSystem.SmartLight
{

    public class PartyLight : RgbLight
    {
        public enum DiscoLight
        {
            On,
            Off
        };

        private DiscoLight _disco;
        public DiscoLight Disco { get; set; }

        public PartyLight():base()
        {
            this.Type = LightType.PartyLight;
            this.Disco = DiscoLight.Off;
        }
        
        public void SetDiscoMode(bool isOn)
        {
            this._disco = isOn ? DiscoLight.On : DiscoLight.Off;
        }
    }

}