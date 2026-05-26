using DependencyInjectionLab.BasicComponents_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLab.GameLoops_2
{
    public class SurvivalGameLoop
    {
        private readonly MonsterSpawner _swpawner;
        private readonly ArenaEnvironment _environment;

        public SurvivalGameLoop(MonsterSpawner swpawner, ArenaEnvironment environment)
        {
            _swpawner = swpawner;
            _environment = environment;
        }

        public void StartSurvivalSession()
        {
            Console.WriteLine("\n--- MODE: SURVIVAL STARTED---");
            string currentAmbience = _environment.GenerateAtmosphere();
            _environment.ApplyScaryAmbience(currentAmbience);

            Console.WriteLine("[SYSTEM] Your task is to survive 3 time cycles in hiding.");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"[Minute {i}/3]: You hear footsteps behind you...");
                _swpawner.SpawnRegular();
            }

            Console.WriteLine("\nDAWN! You made it through the night and survived!");
        }
    }
}
