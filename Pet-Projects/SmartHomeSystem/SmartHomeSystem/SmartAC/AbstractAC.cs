namespace SmartHomeSystem.SmartAC
{

    public abstract class AbstractAC
    {
    
        public enum ACType
        {
            BasicAC,
            AdvancedAC,
            AromaAC 
        };
        
        public enum ACStatus
        {
            On,
            Off
        };

        private int _temp;
        private ACStatus _status;
        private ACType _type;

        public int Temp
        {
            get
            {
                return _temp;
            }
            set
            {
                if (value < 10)
                    _temp = 10;
                
                else if (value > 24)
                    _temp = 25;
                
                else _temp = value; 
            }
        }

        public ACStatus Status { get; set; }
        public ACType Type { get; set; }

        public abstract void Turn(bool isOn);
        public abstract ACStatus GetStatus();
        public abstract int GetTemp();
        public abstract void SetTemp(int temp);
    }

}