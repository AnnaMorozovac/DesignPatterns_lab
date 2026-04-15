using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.decorator
{
    public interface IHero
    {
        string GetStatus();
        double GetHealth();
        int GetSpeed();
    }
}
