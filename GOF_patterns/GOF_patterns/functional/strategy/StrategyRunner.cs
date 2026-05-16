using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.functional.strategy
{
    public static class StrategyRunner
    {
        public static void Levitation()
        {
            Console.WriteLine("You lift off the ground and float silently above the floor");
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("-- Testing the functional strategy --");

            Action carefulStep = () => Console.WriteLine("You walk slowly, feeling the cold walls. It's quiet and safe");
            Action magicDash = () => Console.WriteLine("Flash! You instantly cover distance with a magical dash, spending mana");

            var hero = new HeroSt("Bai Liu", carefulStep);
            hero.Move();
            Console.WriteLine();

            hero.ChangeStrategy(magicDash);
            hero.Move();
            Console.WriteLine();

            hero.ChangeStrategy(Levitation);
            hero.Move();
        }
    }
}
