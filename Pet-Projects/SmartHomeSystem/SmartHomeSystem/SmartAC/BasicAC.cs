namespace SmartHomeSystem.SmartAC
{

    public class BasicAC : AbstractAC
    {
        public BasicAC()
        {
            Status = ACStatus.Off;
            Type = ACType.BasicAC;
            Temp = 17;
        }

        public override void Turn(bool isOn)
        {
            Status = isOn ? ACStatus.On : ACStatus.Off;
        }
        
        public override void SetTemp(int temp)
        {
            Temp = temp;
        }
    }

}