using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.chainofresponsibility
{
    public interface IDamageHandler
    {
        bool CanHandle(DamageRequest request);
        int GetPriority();
        void Handle(DamageRequest request);
        string Name();

    }
}
