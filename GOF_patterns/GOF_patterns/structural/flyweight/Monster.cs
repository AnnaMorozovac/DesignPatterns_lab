using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.flyweight
{
    public class ShadowMonster : IMonster
    {
        public void Stare(string target) =>
            Console.WriteLine($"[SHADOW] Turns empty hood towards: {target}. The air turns icy...");
    }

    public class MirrorMonster : IMonster
    {
        public void Stare(string target) =>
            Console.WriteLine($"[MIRROR] Repeats the movements for: {target}. Are you sure it's you?");
    }
}
