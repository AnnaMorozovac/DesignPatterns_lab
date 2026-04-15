using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.bridge
{
    public class FireElement : IDamageElement
    {
        public string GetEffectDetails() => "Hellfire";
        public void ApplyDamage()
        {
            Console.WriteLine("EFECT: Burn! The player loses 10 HP every second from the fire.");
        }
    }
}
