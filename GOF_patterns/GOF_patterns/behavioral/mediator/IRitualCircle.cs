using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.mediator
{
    public interface IRitualCircle
    {
        void AddAltar(IAltar altar);
        void Notify(IAltar sender, RitualAction action);
    }
}
