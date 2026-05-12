using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.memento
{
    public class HeroSanity
    {
        public string _name { get; }
        private SanityLevel _level;

        public HeroSanity(string name, SanityLevel initialLevel)
        {
            _name = name;
            _level = initialLevel;
        }

        public void EncounterHorror(SanityLevel newLevel)
        {
            Console.WriteLine($"[!] {_name} sees monsters... the state has changed from {_level} to {newLevel}");
            _level = newLevel;
        }

        public HeroSanityMemento GetMemento()
        {
            Console.WriteLine($"[+] The state {_level} is saved in memory.");
            return new HeroSanityMemento(_level);
        }

        public void SetMemento(HeroSanityMemento memento)
        {
            _level = memento.Level;
            Console.WriteLine($"{_name} sanity restored to: {_level}");
        }

        public override string ToString() => $"Current state of consciousness: {_level}";
    }
}
