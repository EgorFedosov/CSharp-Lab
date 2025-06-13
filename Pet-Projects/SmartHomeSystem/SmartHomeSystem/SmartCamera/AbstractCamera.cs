namespace SmartHomeSystem.SmartCamera
{

    public abstract class AbstractCamera : ISmartCamera
    {
        public enum CameraStatus
        {
            On,
            Off
        };

        private CameraStatus _status;

        public CameraStatus Status { get; set; }

        public abstract void Turn(bool isOn);

        public abstract CameraStatus GetStatus();
    }

}