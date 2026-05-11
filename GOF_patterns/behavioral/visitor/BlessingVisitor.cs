using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.visitor
{
    public class BlessingVisitor : IResearchVisitor
    {
        public void VisitAltar(Altar altar)
        {
            Console.WriteLine($"[Spirit-Blessing] Cleanses {altar}. {altar.ManaPower} units of pure mana gained");
        }

        public void VisitStatue(Statue statue)
        {
            Console.WriteLine($"[Spirit-Blessing] Touches {statue}. {statue.Emotion} reigns in the hall");
        }

        public void VisitInscription(Inscription inscription)
        {
            Console.WriteLine($"[Spirit-Blessing] Illuminates {inscription}. Deciphered text: '{inscription.AncientText}'");
        }
    }
}
