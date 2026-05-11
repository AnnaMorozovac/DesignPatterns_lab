using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.mediator
{
    public class ShadowAltar : AltarBase
    {
        public ShadowAltar() : base("Altar of Shadow") { }
        public override void HandleRitual(RitualAction action)
        {
            if (action == RitualAction.activated)
                Console.WriteLine($" -> {Name} absorbs the light around it");
        }
    }
}
