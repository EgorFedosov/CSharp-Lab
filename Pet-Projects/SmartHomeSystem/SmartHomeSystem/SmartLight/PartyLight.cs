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
        
        public void Settings(bool isOn, LightStatus status, LightColor color, bool isDisco )
        {
            base.Settings(isOn, status, color);
            SetDiscoMode(isDisco);
        }
        public void SetDiscoMode(bool isDisco)
        {
            this._disco = isDisco ? DiscoLight.On : DiscoLight.Off;
        }
    }

}