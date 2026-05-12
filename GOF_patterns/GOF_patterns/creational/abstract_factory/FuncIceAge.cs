using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GOF_patterns.creational.abstract_factory
{
    public class MirrorMonster : IMonsters
    {
        public string GetName() => "Mirror Monster";
        public string Attack() => "Mirrors you, and attacks you mentally, too.. [SYSTEM: Learn more types of monster attack]";
    }

    public class ParasiticBandage : IMedicine
    {
        public string GetTitle() => "Parasitic Bandage";
        public string Use() => "Put it on your head so that your health can rise.";
    }

    public class FurCoat : IItems
    {
        public string GetTitle() => "Fur Coat";
        public string Use() => "Cover yourself from the strong wind. Keeps you warm for a while.";
    }
}
