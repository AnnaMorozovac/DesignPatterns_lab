using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.command
{
    public class MonsterInvoker
    {
        private IAttack _attack;

        public void SetCommand(IAttack attack)
        {
            _attack = attack;
        }

        public void Invoke()
        {
            Console.WriteLine("The monster chooses to attack...");
            _attack.Attack();
        }
    }
}
