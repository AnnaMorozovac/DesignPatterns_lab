using GOF_patterns.behavioral.command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.functional.decorator
{
    public static class DecoratorRunner
    {
        private static string ParalyzingFear(string status) => status + " + [PARALYZING FEAR]";
        private static double LowHealth(double health) => health * 0.7;

        private static string Adrenaline(string status) => status + " + [ADRENALIN]";
        private static int BoostSpeed(int speed) => speed + 5;

        public static void Print(FunctionalHero hero)
        {
            Console.WriteLine($"Hero -> Status: {hero.GetStatus()} | Health: {hero.GetHealth()} | Speed: {hero.GetSpeed()}");
        }

        public static void Run()
        {
            Console.WriteLine("-- Testing the functional decorator --");

            Print(new FunctionalHero());
            Print(new FunctionalHero(statusEffects: new[] { ParalyzingFear }, healthEffects: new[] { LowHealth }));
            Print(new FunctionalHero(statusEffects: new[] { Adrenaline }, speedEffects: new[] { BoostSpeed }));

            Print(new FunctionalHero(
                statusEffects: new[] { ParalyzingFear, Adrenaline },
                healthEffects: new[] { LowHealth },
                speedEffects: new[] { BoostSpeed }
                ));
        }
    }
}
