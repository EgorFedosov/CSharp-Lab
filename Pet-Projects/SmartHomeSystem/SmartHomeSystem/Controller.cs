using System.ComponentModel;
using System.Diagnostics;
using SmartHomeSystem.SmartAC;
using SmartHomeSystem.SmartCamera;
using SmartHomeSystem.SmartLight;

namespace SmartHomeSystem
{

    public class Controller
    {
        public enum Scenario
        {
            Home,
            Leav,
            GoodNight,
            GoodMorning,
            Party,
            DeviceInfo
        }
        /*
         * дом - включены 7 ламп, 5 обычных и 2 ргб желтый цыет
         * Лив - Все лампы выкл, кондционеры выкл
         * ночь - вкл только 2 желтых ламбы, кондиционер 1 с запахом эквалипт и лоу
         * утро - ламбы офф, 2 кондиционера базовых
         * парти - базовые лампы офф, ргб вкл разные цвета, диско вкл, кондиционеры медиум с фруктами
         * инфо - какой сценарий, что включено, какие режимы  
         */
        private List<ISmartLight> _allLights = [];
        private List<ISmartAC> _allAcs = [];
        private List<ISmartCamera> _allCameras = [];

        private Scenario _scenario;
        public Scenario Scenar { get; set; }

        public Controller()
        {
            InitializeLights();
            InitializeCameras();
            InitializeACs();
        }

        private void InitializeLights()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                    _allLights.Add(new PartyLight());
                else if (i % 2 == 0)
                    _allLights.Add(new BasicLight());
                else
                    _allLights.Add(new RgbLight());
            }
        }

        private void InitializeCameras()
        {
            for (int i = 0; i < 10; i++)
            {
                _allCameras.Add(new BasicCamera());
            }
        }

        private void InitializeACs()
        {
            _allAcs.Add(new BasicAC());
            _allAcs.Add(new BasicAC());
            _allAcs.Add(new AdvancedAC());
            _allAcs.Add(new AdvancedAC());
            _allAcs.Add(new AromaAC());
        }

        
        public void SetScenario(Scenario scenario)
        {
            
        }
    }

}