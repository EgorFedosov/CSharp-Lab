using SmartHomeSystem.SmartLight;

namespace SmartHomeSystem.SmartAC
{

    public class AromaAC : AdvancedAC
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
            Type = ACType.AromaAC;
            Scent = null;
            Zone = FlowZone.Front;
        }

        public void ChangeScent(ScentAC scent)
        {
            Scent = scent;
        }

        public void ChangeZoneFlow(FlowZone zone)
        {
            Zone = zone;
        }

        public void Settings(bool isOn, int temp, FlowSpeed speed, FlowZone zone, ScentAC scent)
        {
            base.Settings(isOn, temp, speed);
            ChangeScent(scent);
            ChangeZoneFlow(zone);
        }
    }

}