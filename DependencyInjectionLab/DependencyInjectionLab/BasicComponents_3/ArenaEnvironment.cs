using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLab.BasicComponents_3
{
    public class ArenaEnvironment
    {
        private readonly string[] _weatherEffects =
        {
            "Thick otherworldly fog (visibility 1 meter)",
            "Blood rain that blinds the eyes",
            "Absolute, pitch-black darkness",
            "Thunderstorm with red lightning"
        };

        private readonly Random _random = new Random();

        public string GenerateAtmosphere()
        {
            int index = _random.Next(_weatherEffects.Length);
            return _weatherEffects[index];
        }

        public void ApplyScaryAmbience(string ambience)
        {
            Console.WriteLine($"\n[AMBIENCE]: {ambience}. The player's pulse quickens...");
        }
    }
}