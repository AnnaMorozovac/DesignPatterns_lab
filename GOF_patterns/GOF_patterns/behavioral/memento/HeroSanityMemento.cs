using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.memento
{
    public class HeroSanityMemento
    {
        public SanityLevel Level { get; }
 
        public HeroSanityMemento(SanityLevel level)
        {
            Level = level;
        }
    }
}
