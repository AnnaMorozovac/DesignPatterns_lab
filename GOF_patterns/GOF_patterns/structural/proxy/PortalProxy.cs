using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.proxy
{
    public class PortalProxy : IArenaWorld
    {
        private const int num_allowed = 3;
        private readonly List<ShadowServant> _shadows;
        private readonly RealArenaWorld _arenaWorld;

        public PortalProxy()
        {
            _shadows = new List<ShadowServant>();
            _arenaWorld = new RealArenaWorld();
        }

        public void EnterWorld(ShadowServant shadow)
        {
            Console.WriteLine($"Portal: {shadow} is attempting to cross the void...");
            if (_shadows.Count < num_allowed)
            {
                _shadows.Add(shadow);
                _arenaWorld.EnterWorld(shadow);
            }
            else
            {
                Console.WriteLine($"Portal: {shadow} cannot pass. Realities fabrics are too thin. Portal is unstable!");
            }
        }
    }
}
