namespace SmartHomeSystem.SmartLight
{

    public interface ISmartLight
    {
        void Turn(bool isOn);

        AbstractLight.LightStatus Status{ get; set; }
    }

}