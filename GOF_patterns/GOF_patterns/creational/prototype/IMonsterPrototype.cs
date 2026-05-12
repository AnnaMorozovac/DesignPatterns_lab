using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.prototype
{
    public interface IMonsterPrototype
    {
        IMonsterPrototype Clone();
        void ShowMonsterInfo();
    }
}
