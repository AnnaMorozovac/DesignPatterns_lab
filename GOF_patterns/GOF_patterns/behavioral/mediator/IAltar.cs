using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.mediator
{
    public interface IAltar
    {
        string Name { get; }
        void SetCircle(IRitualCircle circle);
        void HandleRitual(RitualAction action);
        void PerformAction(RitualAction action);
    }
}
