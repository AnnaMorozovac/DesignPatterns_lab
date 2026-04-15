using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.composite
{
    public class Room : ArenaComponent
    {
        private string _name;
        public Room(string name) => _name = name;

        public override void DisplayMap(int depth)
        {
            if (IsOpened)
                Console.WriteLine(new string('-', depth) + $" [OPEN] Room {_name}");
            else
                Console.WriteLine(new string('-', depth) + " [LOCKED] ???");
        }
    }
}
