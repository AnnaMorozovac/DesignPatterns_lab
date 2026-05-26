using DependencyInjectionLab.BasicComponents_3;
using System;

namespace DependencyInjectionLab.GameLoops_2
{
    public class FearVisualizer
    {
        private readonly ArenaEnvironment _environment;

        public FearVisualizer(ArenaEnvironment environment)
        {
            _environment = environment;
        }

        public void ShowScaryForecast()
        {
            string weather = _environment.GenerateAtmosphere();
            Console.WriteLine($"\n[VISUALIZER]: Scanning the perimeter... Current threat level: CRITICAL.");
            Console.WriteLine($"[VISUALIZER]: Detected atmospheric anomaly: '{weather}'");
        }
    }
}