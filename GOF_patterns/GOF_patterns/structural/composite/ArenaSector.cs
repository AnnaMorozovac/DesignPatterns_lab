using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.composite
{
    public class ArenaSector : ArenaComponent
    {
        private string _name;
        public ArenaSector(string name) => _name = name;

        public override void DisplayMap(int depth)
        {
            if (!IsOpened)
            {
                Console.WriteLine(new string(' ', depth) + $"SECTOR: {_name} [HIDDEN]  ");
                return;
            }

            Console.WriteLine(new string(' ', depth) + $"SECTOR: {_name} [REVEALED]  ");
            foreach (var component in components)
            {
                component.DisplayMap(depth + 2);
            }
        }
    }
}
