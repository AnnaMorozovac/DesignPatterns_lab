using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.bridge
{
    public class SpikeTrap : ITrap
    {
        private readonly IDamageElement _element;

        public SpikeTrap(IDamageElement element)
        {
            _element = element; 
        }

        public void Trigger()
        {
            Console.WriteLine("Sharp spikes are flying out of the floor!");
            _element.ApplyDamage();
        }

        public IDamageElement GetElement() => _element;
    }

    public class CrushingWall : ITrap
    {
        private readonly IDamageElement _element;

        public CrushingWall(IDamageElement element)
        {
            _element= element;
        }

        public void Trigger()
        {
            Console.WriteLine("The walls begin to collapse with a roar!");
            _element.ApplyDamage();
        }
        
        public IDamageElement GetElement() => _element;
    }
}
