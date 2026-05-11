using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.strategy
{
    public class CarefulStepStrategy : IMovementStrategy
    {
        public void Execute()
        {
            Console.WriteLine("You walk slowly, feeling the cold walls. It's quiet and safe");
        }
    }

    public class MagicDashStrategy : IMovementStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Flash! You instantly cover distance with a magical dash, spending mana");
        }
    }

    public class LevitationStrategies : IMovementStrategy
    {
        public void Execute()
        {
            Console.WriteLine("You lift off the ground and float silently above the floor");
        }
    }
}
