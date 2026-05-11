using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.iterator
{
    public class PotionBelt
    {
        private readonly List<Potion> _potions;

        public PotionBelt(List<Potion> potions)
        {
            _potions = potions;
        }

        public List<Potion> GetPotions() => new List<Potion>(_potions);

        public IPotionIterator GetIterator(PotionType type)
        {
            return new PotionBeltIterator(this, type);
        }
    }
}
