using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.builder
{
    public class Hero
    {
        public string Name { get; set; }
        public string Health { get; set; }
        public string Psychics { get; set; }
        public string ClassType { get; set; }
        public string PrimaryWeapon { get; set; }
        public List<string> Inventory { get; private set; } = new List<string>();

        private Hero() { }

        public void ShowStats()
        {
            Console.WriteLine($"--- STATS -> {Name} ---");
            Console.WriteLine($"Health: {Health}/100    | Psychics: {Psychics}");
            Console.WriteLine($"Class: {ClassType}   | Weapon: {PrimaryWeapon}");
            Console.WriteLine($"Inventory: {(Inventory.Count > 0 ? string.Join(", ", Inventory) : "empty")}");
        }

        public class Builder
        {
            private Hero _hero = new Hero();

            public Builder(string name)
            {
                _hero.Name = name;
                _hero.Health = "100";
                _hero.Psychics = "stable";
            }
            
            public Builder WithHealth(int hp)
            {
                if (hp > 100) hp = 100;
                if (hp < 0) hp = 0;

                _hero.Health = hp.ToString();
                return this;
            }

            public Builder WithPsychics(string mental)
            {
                _hero.Psychics = mental;
                return this;
            }

            public Builder WithClass(string classType)
            {
                _hero.ClassType = classType;
                return this;
            }

            public Builder WithWeapon(string weapon)
            {
                _hero.PrimaryWeapon = weapon;
                return this;
            }

            public Builder AddInventory(string item)
            {
                _hero.Inventory.Add(item);
                return this;
            }

            public Hero Build()
            {
                return _hero;
            }
        }
    }
}
