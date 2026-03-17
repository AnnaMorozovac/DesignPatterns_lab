using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.factory_method
{
    public class HauntedHouseSwaper : GameSwaper
    {
        public override IGameInstance CreateGame() => new HauntedHouseGame();
    }
}
