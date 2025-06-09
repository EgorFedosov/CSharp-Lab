namespace SmartHomeSystem.SmartLight
{

    public class BasicLight : AbstractLigth
    {
        public BasicLight()
        {
            this.Type = LightType.BasicLight;
            this.Status = LightStatus.Off;
        }

        public override void Turn(bool isOn)
        {
            this.Status = isOn ? LightStatus.On : LightStatus.Off;
        }

        public override LightStatus GetStatus()
        {
            return this.Status;
        }
    }

}