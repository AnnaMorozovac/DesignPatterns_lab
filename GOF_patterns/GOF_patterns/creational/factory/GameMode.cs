using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.factory
{
    public class SurvivalMode : IGameMode
    {
        public string Title => "Survival";
        public void ApplyRules() => Console.WriteLine("[RULES] If you die, you can go back. Take care of your health");
    }

    public class InsanityMode : IGameMode
    {
        public string Title => "Insanity";
        public void ApplyRules() => Console.WriteLine("[RULES] Health generation is disabled. If your die, you will become a monster.");
    }
}
