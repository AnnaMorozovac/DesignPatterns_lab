using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.flyweight
{
    public class Horde
    {
        private readonly MonsterFactory _factory;
        private readonly List<(MonsterType type, string target)> _monsterFocus = new();

        public Horde(MonsterFactory factory) => _factory = factory;

        public void SetTarget(MonsterType type, string targetName)
        {
            _monsterFocus.Add((type, targetName));
        }

        public void Update()
        {
            Console.WriteLine("[SYSTEM] THOUSANDS OF EYES FOCUS");
            foreach (var item in _monsterFocus)
            {
                var monster = _factory.GetMonster(item.type);
                monster.Stare(item.target);
            }
        }
    }
}
