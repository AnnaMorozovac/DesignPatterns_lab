using DependencyInjectionLab.BasicComponents_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLab.GameLoops_2
{
    public class NightmareGenerator
    {
        private readonly MonsterSpawner _swpawner;
        private readonly ArenaEnvironment _environment;

        public NightmareGenerator(MonsterSpawner swpawner, ArenaEnvironment environment)
        {
            _swpawner = swpawner;
            _environment = environment;
        }

        public void AnalyzeCurrentFearFactory()
        {
            Console.WriteLine("\n[Nightmare Generator]: I read your fears...");
            string predictedWeather = _environment.GenerateAtmosphere();

            Console.WriteLine($"Arena Forecast: '{predictedWeather}' is expected.");
            if (predictedWeather.Contains("darkness"))
            {
                Console.WriteLine("Attention: Monsters will attack twice as fast!");
            }
            else
            {
                Console.WriteLine("Tip: Keep your flashlight on.");
            }
        }
    }
}
