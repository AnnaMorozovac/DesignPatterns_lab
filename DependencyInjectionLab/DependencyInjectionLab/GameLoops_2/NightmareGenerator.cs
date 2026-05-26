using DependencyInjectionLab.BasicComponents_3; 
using System;

namespace DependencyInjectionLab.GameLoops_2
{
    public class NightmareGenerator
    {
        private readonly MonsterSpawner _swpawner;
        private readonly FearVisualizer _visualizer;

        public NightmareGenerator(MonsterSpawner swpawner, FearVisualizer visualizer)
        {
            _swpawner = swpawner;     
            _visualizer = visualizer;  
        }

        public void AnalyzeCurrentFearFactory()
        {
            Console.WriteLine("\n[Nightmare Generator]: Reading your fears via visualizer...");

            _visualizer.ShowScaryForecast();

            Console.WriteLine("[Nightmare Generator]: Analysis complete. Prepare to suffer!");
        }
    }
}