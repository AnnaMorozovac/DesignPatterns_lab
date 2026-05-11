using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.mediator
{
    public class RitualCircleImpl : IRitualCircle
    {
        private readonly List<IAltar> _altars = new List<IAltar>();

        public void AddAltar(IAltar altar)
        {
            _altars.Add(altar);
            altar.SetCircle(this);
            Console.WriteLine($"{altar.Name} attached to the circle of ritual");
        }

        public void Notify(IAltar sender, RitualAction action)
        {
            foreach (var altar in _altars)
            {
                if (altar != sender)
                {
                    altar.HandleRitual(action);
                }
            }
        }
    }
}
