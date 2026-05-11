using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.iterator
{
    public class Potion
    {
        public string _name { get; }
        public PotionType _potionType { get; }

        public Potion(string name, PotionType potionType)
        {
            _name = name;
            _potionType = potionType;
        }
    }
}
