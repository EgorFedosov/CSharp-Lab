namespace SmartHomeSystem.SmartCamera
{

    public interface ISmartCamera
    {
        void Turn(bool isOn);
        AbstractCamera.CameraStatus GetStatus();
    }

}