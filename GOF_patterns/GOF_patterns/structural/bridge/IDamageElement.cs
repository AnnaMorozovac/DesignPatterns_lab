using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.bridge
{
     public interface IDamageElement
    {
        string GetEffectDetails();
        void ApplyDamage();
    }
}
