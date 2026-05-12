using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.mediator
{
    public abstract class AltarBase : IAltar
    {
        public string Name { get; }
        protected IRitualCircle _circle;

        protected AltarBase(string name) => Name = name;

        public void SetCircle(IRitualCircle circle) => _circle = circle;

        public virtual void PerformAction(RitualAction action)
        {
            Console.WriteLine($"[!] {Name}: performs a ritual {action}");
            _circle?.Notify(this, action);
        }

        public abstract void HandleRitual(RitualAction action);

        public override string ToString() => Name;
    }
}
