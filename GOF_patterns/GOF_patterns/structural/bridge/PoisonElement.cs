using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.bridge
{
    public class PoisonElement :  IDamageElement
    {
        public string GetEffectDetails() => "Deadly toxin";
        public void ApplyDamage()
        {
            Console.WriteLine("EFECT: Poisoning! The player's speed is reduced, vision is blurred.");
        }
    }
}
