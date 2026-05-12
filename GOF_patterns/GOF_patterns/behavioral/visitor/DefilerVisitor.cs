using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.visitor
{
    public class DefilerVisitor : IResearchVisitor
    {
        public void VisitAltar(Altar altar)
        {
            Console.WriteLine($"[Defiler Spirit] Absorbs the energy of {altar}. The altar fades...");
        }

        public void VisitStatue(Statue statue)
        {
            Console.WriteLine($"[Defiler Spirit] Destroys {statue}. Instead of peace comes terror");
        }

        public void VisitInscription(Inscription inscription)
        {
            Console.WriteLine($"[Defiler Spirit] Distorts {inscription}. Now only a curse is written there.");
        }
    }
}
