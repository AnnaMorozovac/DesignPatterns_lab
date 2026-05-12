using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.decorator
{
    public class FearDecorator : HeroDecorator
    {
        public FearDecorator(IHero hero) : base(hero) { }

        public override string GetStatus() => base.GetStatus() + " + [PARALYZING FEAR]";
        public override double GetHealth() => base.GetHealth() * 0.7;
    }

    public class AdrenalineDecorator : HeroDecorator
    {
        public AdrenalineDecorator(IHero hero) : base(hero) {}

        public override string GetStatus() => base.GetStatus() + " + [ADRENALIN]";
        public override int GetSpeed() => base.GetSpeed() + 5;
    }
}
