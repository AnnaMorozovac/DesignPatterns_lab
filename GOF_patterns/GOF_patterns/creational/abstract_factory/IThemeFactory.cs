using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.abstract_factory
{
    public interface IThemeFactory
    {
        IMonsters CreateMonster();
        IMedicine CreateMedecine();
        IItems CreateItem();
    }
}
