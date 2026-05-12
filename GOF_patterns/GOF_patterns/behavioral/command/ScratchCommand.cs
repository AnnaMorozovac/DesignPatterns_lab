using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.command
{
    public class ScratchCommand : IAttack
    {
        private readonly Hero _hero;
        private readonly int _damage;

        public ScratchCommand(Hero hero, int damage)
        {
            _hero = hero;
            _damage = damage;
        }

        public void Attack()
        {
            _hero.TakeBite(_damage);
        }
    }
}
