namespace SmartHomeSystem.SmartAC
{

    public interface ISmartAC
    {
       
        
        void Turn(bool isOn);
        int GetTemp();
        AbstractAC.ACStatus GetStatus();
    }

}