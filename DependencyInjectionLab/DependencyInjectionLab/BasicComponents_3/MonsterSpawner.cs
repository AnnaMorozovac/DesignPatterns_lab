using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLab.BasicComponents_3
{
    public class MonsterSpawner
    {
        private readonly string[] _regularMonsters = { "The Haunted House", "Shadow Stalker", "Cursed Doll" };
        private readonly string[] _bossMonsters = { "The Queen of Spiders", "The Executioner with the Rusty Axe", "Leviathan of the Abyss" };
        private readonly Random _random = new Random();

        public void SpawnRegular()
        {
            string monster = _regularMonsters[_random.Next(_regularMonsters.Length)];
            Console.WriteLine($"[SPAWN]: From a dark corner crawls out: **{monster}**! Eyes glow red.");
        }

        public void SpawnBoss()
        {
            string boss = _bossMonsters[_random.Next( _bossMonsters.Length)];
            Console.WriteLine($"[BOSS SPAWN]: THE EARTH SHAKES! BOSS has appeared: === {boss} ===!");
        }
    }
}
