namespace SmartHomeSystem.SmartLight
{

    public abstract class AbstractLigth: ISmartLight
    {
        public enum LightType
        {
            BasicLight,
            RgbLight,
            PartyLight
        };
        
        public enum LightStatus
        {
            On,
            Off
        };
       
        private LightStatus _status;
        private LightType _type;

        public LightStatus Status { get; set; }
        public LightType Type { get; set; }

        public abstract void Turn(bool isOn);
        public abstract LightStatus GetStatus();
    }

}