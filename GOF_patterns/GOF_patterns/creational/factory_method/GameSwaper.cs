using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.factory_method
{
    public abstract class GameSwaper
    {
        public abstract IGameInstance CreateGame();

        public void RunGameProcess()
        {
            var game = CreateGame();
            Console.WriteLine($"--- [SYSTEM] PREPARING THE WORLD: {game.Title} ---");
            game.StartInstance();
            Console.WriteLine("-> THE GAME HAS BEGUN ");
        }
    }
}
