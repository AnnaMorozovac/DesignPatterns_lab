using GOF_patterns.behavioral.mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.visitor
{
    public interface IResearchVisitor
    {
        void VisitAltar(Altar altar);
        void VisitStatue(Statue statue);
        void VisitInscription(Inscription inscription);
    }
}
