using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.flyweight
{
    public class MonsterFactory
    {
        private readonly Dictionary<MonsterType, IMonster> _monsters = new();

        public IMonster GetMonster(MonsterType monsterType)
        {
            if (!_monsters.ContainsKey(monsterType))
            {
                _monsters[monsterType] = monsterType switch
                {
                    MonsterType.Shadow => new ShadowMonster(),
                    MonsterType.MirrorHuman => new MirrorMonster(),
                    _ => throw new ArgumentException("Unknown type")
                };
            }

            return _monsters[monsterType];
        }
    }
}
