namespace SmartHomeSystem.SmartAC
{

    public class AdvancedAC : BasicAC
    {
        public enum FlowSpeed
        {
            Low,
            Medium,
            High 
        };

        private FlowSpeed _speed;
        public FlowSpeed Speed { get; set; }

        public AdvancedAC() : base()
        {
            this.Type = ACType.AdvancedAC;
            this.Speed = FlowSpeed.Medium;

        }

        public void ChangeSpeed(FlowSpeed speed)
        {
            this.Speed = speed;
        }
    }

}