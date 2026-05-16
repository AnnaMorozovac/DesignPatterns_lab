using GOF_patterns.behavioral.strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.functional.strategy
{
    public class HeroSt
    {
        private Action _movmentStrategy;
        public string Name { get; }

        public HeroSt(string name, Action initialStrategy)
        {
            Name = name;
            _movmentStrategy = initialStrategy;
        }

        public void ChangeStrategy(Action newStrategy)
        {
            _movmentStrategy = newStrategy;
            Console.WriteLine($"[!] {Name} changes the way you move");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} starts moving:");
            _movmentStrategy();
        }
    }
}
