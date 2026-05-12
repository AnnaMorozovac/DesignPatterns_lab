using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.factory
{
    public static class GameModefactory
    {
        public static IGameMode CreateMode(GameModeType type)
        {
            return type switch
            {
                GameModeType.Survival => new SurvivalMode(),
                GameModeType.Insanity => new InsanityMode(),
                _ => throw new ArgumentException("This game does not exist.")
            };
        }
    }
}
