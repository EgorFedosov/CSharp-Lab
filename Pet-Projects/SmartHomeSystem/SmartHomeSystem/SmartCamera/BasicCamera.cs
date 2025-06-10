namespace SmartHomeSystem.SmartCamera
{

    public class BasicCamera: AbstractCamera
    {
        public override void Turn(bool isOn)
        {
            this.Status = isOn ? CameraStatus.On : CameraStatus.Off;
        }

        public override CameraStatus GetStatus()
        {
            return this.Status;
        }
    }

}