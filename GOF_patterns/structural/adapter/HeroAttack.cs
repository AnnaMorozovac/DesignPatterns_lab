using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.adapter
{
    public class HeroAttack
    {
        private readonly IModernWeapon _modernWeapon;

        public HeroAttack(IModernWeapon modernWeapon)
        {
            _modernWeapon = modernWeapon;
        }

        public void ExecuteAttack()
        {
            Console.WriteLine("BATTLE: The system triggers the weapon...");
            _modernWeapon.Use();
        }
    }
}
