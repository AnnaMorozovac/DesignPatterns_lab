using GOF_patterns.creational.abstract_factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.prototype
{
    public class MirrorMonsters : IMonsterPrototype
    {
        public string Name { get; set; }
        public string Attack { get; set; }

        public MirrorMonsters(string name, string attack)
        {
            Name = name;
            Attack = attack;
        }

        public IMonsterPrototype Clone()
        {
            return (IMonsterPrototype)this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            if (obj is MirrorMonsters other)
            {
                return this.Attack == other.Attack && this.Name == other.Name;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name, Attack).GetHashCode();
        }

        public void ShowMonsterInfo()
        {
            Console.WriteLine($"MONSTER: {Name} \nATTACK: {Attack}");
        }
    }
}
