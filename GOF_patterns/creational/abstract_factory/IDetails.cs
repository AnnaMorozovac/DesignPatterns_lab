using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.abstract_factory
{
    public interface IMonsters
    {
        string GetName();
        string Attack();
    }

    public interface IMedicine
    {
        string GetTitle();
        string Use();
    }

    public interface IItems
    {
        string GetTitle();
        string Use();
    }
}
