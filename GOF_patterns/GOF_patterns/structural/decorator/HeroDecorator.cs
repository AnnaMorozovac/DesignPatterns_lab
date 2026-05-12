using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.decorator
{
    public class HeroDecorator : IHero
    {
        protected readonly IHero _decoratedHero;

        public HeroDecorator(IHero decoratedHero)
        {
            _decoratedHero = decoratedHero;
        }

        public virtual string GetStatus() => _decoratedHero.GetStatus();
        public virtual double GetHealth() => _decoratedHero.GetHealth();
        public virtual int GetSpeed() => _decoratedHero.GetSpeed();
    }
}
