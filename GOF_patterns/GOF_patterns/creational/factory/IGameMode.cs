using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.factory
{
    public interface IGameMode
    {
        string Title { get; }
        void ApplyRules();
    }
}
