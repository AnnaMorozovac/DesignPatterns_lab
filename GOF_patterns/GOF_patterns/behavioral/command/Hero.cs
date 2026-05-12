using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.command
{
    public class Hero
    {
        public string Name { get; }
        public int Health {  get; private set; } 

        public Hero(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeBite(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} got bitten! \n Dealt {damage} damage. HP: {Health}");
        }

        public void TakeScratch(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} got a scratch! \n Dealt {damage} damage. HP: {Health}");
        }
    }
}
