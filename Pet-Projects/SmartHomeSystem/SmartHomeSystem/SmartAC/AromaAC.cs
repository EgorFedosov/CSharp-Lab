using SmartHomeSystem.SmartLight;

namespace SmartHomeSystem.SmartAC
{

    public class AromaAC: AdvancedAC
    {
        public enum FlowZone
        {
            Front,
            Back,
            left,
            right,
            All
        }

        public enum ScentAC
        {
            Freshness,
            FruityNote,
            Eucalyptus
        }

        private FlowZone _zone;
        private ScentAC? _scent;
        
        public FlowZone Zone { get; set; }
        public ScentAC? Scent { get; set; }

        public AromaAC() : base()
        {
            this.Type = ACType.AromaAC;
            this.Scent = null;
            this.Zone = FlowZone.Front;
        }

        public void ChangeScent(ScentAC scent)
        {
            this.Scent = scent;
        }
        
        public void ChangeZoneFlow(FlowZone zone)
        {
            this.Zone = zone;
        }
    }

}