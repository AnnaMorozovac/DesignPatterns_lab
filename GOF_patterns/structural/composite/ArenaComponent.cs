using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.composite
{
    public abstract class ArenaComponent
    {
        protected readonly List<ArenaComponent> components = new List<ArenaComponent>();
        public bool IsOpened { get; protected set; } = false;

        public void Add(ArenaComponent component) => components.Add(component);

        public virtual void Reveal()
        {
            IsOpened = true;
            foreach (var component in components)
            {
                component.Reveal();
            }
        }

        public abstract void DisplayMap(int depth = 0);
    }
}
