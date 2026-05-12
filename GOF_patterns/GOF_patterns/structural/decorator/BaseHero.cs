using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.decorator
{
    public class BaseHero : IHero
    {
        public string GetStatus() => "Stable condition";
        public double GetHealth() => 100.0;
        public int GetSpeed() => 10;
    }
}
