 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.facade
{
    public class LightingSystem : ArenaComponent
    {
        public LightingSystem(string name) : base(name) { }
        public override void PerformUniqueEffect() => Console.WriteLine($"[{Name}] The light stops flashing.");
    }

    public class AudioSystem : ArenaComponent
    {
        public AudioSystem(string name) : base(name) { }
        public override void PerformUniqueEffect() => Console.WriteLine($"[{Name}] Plays the sounds of footsteps behind the player.");
    }
}
