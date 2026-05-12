using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.facade
{
    public class HorrorArenaFacade
    {
        private readonly List<ArenaComponent> _components;

        public HorrorArenaFacade()
        {
            _components = new List<ArenaComponent>
            {
                new LightingSystem("Lighting Stations"),
                new AudioSystem("Environment system")
            };

        }

        public void BossAwakeningMode()
        {
            Console.WriteLine("\n[SYSTEM] THE BOSS HAS AWAKEN: ACTIVATING HORROR MODE");
            Execute(ArenaAction.FLICKER, ArenaAction.ACTIVATE);
        }

        public void TriggerAmbientMode()
        {
            Console.WriteLine("\n[SYSTEM] BOSS DESTROYED: PASSIVE OPRESSION MODE");
            Execute(ArenaAction.PLAY_AMBIENCE, ArenaAction.STANBY, ArenaAction.DEACTIVATE);
        }

        private void Execute(params ArenaAction[] actions)
        {
            foreach (var component in _components)
            {
                component.Execute(actions);
            }
        }
    }
}
