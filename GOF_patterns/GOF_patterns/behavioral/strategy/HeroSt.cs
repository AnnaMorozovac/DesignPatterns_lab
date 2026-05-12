using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.strategy
{
    public class HeroSt
    {
        private IMovementStrategy _strategy;
        public string Name { get; }

        public HeroSt(string name, IMovementStrategy initialStrategy)
        {
            Name = name;
            _strategy = initialStrategy;
        }

        public void ChangeStrategy(IMovementStrategy strategy)
        {
            _strategy = strategy;
            Console.WriteLine($"[!] {Name} changes the way you move");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} starts moving:");
            _strategy.Execute();
        }
    }
}
