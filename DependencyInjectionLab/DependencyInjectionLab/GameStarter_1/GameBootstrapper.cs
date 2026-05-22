using DependencyInjectionLab.GameLoops_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLab.GameStarter_1
{
    public class GameBootstrapper
    {
        private readonly SurvivalGameLoop _survivalLoop;
        private readonly DeathmatchGameLoop _deathmatchLoop;
        private readonly NightmareGenerator _nightmareGenerator;

        public GameBootstrapper(
            SurvivalGameLoop survivalLoop, DeathmatchGameLoop deathmatchLoop, NightmareGenerator nightmareGenerator)
        {
            _survivalLoop = survivalLoop;
            _deathmatchLoop = deathmatchLoop;
            _nightmareGenerator = nightmareGenerator;
        }

        public void Run()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("   STARTING THE ARENA SIMULATION   ");
            Console.WriteLine("===================================");

            _nightmareGenerator.AnalyzeCurrentFearFactory();

            Console.WriteLine("\n[STAGE 1]: Entering the Dark Zone...");
            _survivalLoop.StartSurvivalSession();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("[STAGE 2]: The gate is closing. There is no turning back...");
            _deathmatchLoop.StartDeathmatchSession();
        }
    }
}
