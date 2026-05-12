using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.mediator
{
    public class BloodAltar : AltarBase
    {
        public BloodAltar() : base("Altar of Blood") { }
        public override void HandleRitual(RitualAction action)
        {
            if (action == RitualAction.activated)
                Console.WriteLine($" -> {Name} starts to pulsate with red light");
        }
    }
}
