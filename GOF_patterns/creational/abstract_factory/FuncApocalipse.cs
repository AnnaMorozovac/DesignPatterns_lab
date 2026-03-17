using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.abstract_factory
{
    public class Zombie : IMonsters 
    {
        public string GetName() => "Zombie";
        public string Attack() => "Attacks with the infected limb and.. [SYSTEM: Learn more types of monster attack]";
    }

    public class Antidote : IMedicine
    {
        public string GetTitle() => "Antidote";
        public string Use() => "Drink a bottle of antidote to cure the zombie infection.";
    }

    public class Gun : IItems
    {
        public string GetTitle() => "Gun";
        public string Use() => "Stuns zombies for a few minutes. Shoot in the head!";
    }
}
