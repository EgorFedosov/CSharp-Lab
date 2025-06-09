namespace SmartHomeSystem.SmartLight
{

    public interface ISmartLight
    {
        
        void Turn(bool isOn);
        AbstractLigth.LightStatus GetStatus();
        
    }
    
}
