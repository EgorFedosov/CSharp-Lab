namespace SmartHomeSystem.SmartAC
{

    public class BasicAC: AbstractAC
    {
        public BasicAC()
        {
            this.Status = ACStatus.Off;
            this.Type = ACType.BasicAC;
            this.Temp = 17;
        }
        public override void Turn(bool isOn)
        {
            this.Status = isOn ? ACStatus.On : ACStatus.Off;
        }

        public override ACStatus GetStatus()
        {
            return this.Status;
        }

        public override int GetTemp()
        {
            return this.Temp;
        }

        public override void SetTemp(int temp)
        {
            this.Temp = temp;
        }
    }

}