using DependencyInjectionLab.BasicComponents_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLab.GameLoops_2
{
    public class DeathmatchGameLoop
    {
        private readonly MonsterSpawner _swpawner;
        private readonly ArenaEnvironment _environment;

        public DeathmatchGameLoop(MonsterSpawner swpawner, ArenaEnvironment environment)
        {
            _swpawner = swpawner;
            _environment = environment;
        }

        public void StartDeathmatchSession()
        {
            Console.WriteLine("\n--- MODE: DEATH FIGHT STARTED ---");
            _environment.ApplyScaryAmbience("Bloody fog covers the floor");

            Console.WriteLine("There is no hiding place here. The gate is closed. Only battle!");

            _swpawner.SpawnRegular();
            _swpawner.SpawnBoss();

            Console.WriteLine("\nThe battle is over! The enemies are defeated, but the Arena awaits your return...");
        }
    }
}
