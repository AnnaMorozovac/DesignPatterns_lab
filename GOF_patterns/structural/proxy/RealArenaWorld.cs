using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.proxy
{
    public class RealArenaWorld : IArenaWorld
    {
        public void EnterWorld(ShadowServant shadow)
        {
            Console.WriteLine($"[SYSTEM] The fabric of reality is torn as {shadow} enters the Game!");
        }
    }
}
