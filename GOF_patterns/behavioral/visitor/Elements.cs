using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.visitor
{
    public class Altar : IArenaElement
    {
        public int ManaPower => 50;
        public void Accept(IResearchVisitor visitor) => visitor.VisitAltar(this);
        public override string ToString() => "Ancient Altar";
    }

    public class Statue : IArenaElement
    {
        public string Emotion => "Rest";
        public void Accept(IResearchVisitor visitor) => visitor.VisitStatue(this);
        public override string ToString() => "Gloomy Statue";
    }

    public class Inscription : IArenaElement
    {
        public string AncientText => "The Secret of Immortality";
        public void Accept(IResearchVisitor visitor) => visitor.VisitInscription(this);
        public override string ToString() => "A time-honored inscription";
    }
}
