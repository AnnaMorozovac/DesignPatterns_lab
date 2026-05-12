using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.state
{
    public interface IMedallionState
    {
        void OnEncounter(Medallion context);
        string GetDescription();
    }
}
