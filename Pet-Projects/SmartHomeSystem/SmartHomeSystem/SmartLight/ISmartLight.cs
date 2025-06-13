namespace SmartHomeSystem.SmartLight
{

    public interface ISmartLight
    {
        void Turn(bool isOn);
        void Settings(bool isOn, AbstractLight.LightStatus status);
        AbstractLight.LightStatus GetStatus();
    }

}