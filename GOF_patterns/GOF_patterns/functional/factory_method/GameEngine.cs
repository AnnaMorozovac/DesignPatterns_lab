using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.functional.factory_method
{
    public static class GameEngine
    {
        public static void RunGameProcess(Func<IGameInstance> gameFactory)
        {
            var game = gameFactory();

            Console.WriteLine($"--- [SYSTEM] PREPARING THE WORLD: {game.Title} ---");
            game.StartInstance();
            Console.WriteLine("-> THE GAME HAS BEGUN ");
        }
    }
}
