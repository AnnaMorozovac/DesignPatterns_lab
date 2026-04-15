using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.facade
{
    public enum ArenaAction
    {
        ACTIVATE, DEACTIVATE, FLICKER, PLAY_AMBIENCE, STANBY
    }

    public abstract class ArenaComponent
    {
        public string Name { get; }

        protected ArenaComponent(string name) => Name = name;

        public virtual void Activate() => Console.WriteLine($"[{Name}] - ACTIVATED (Maximum Danger)");
        public virtual void Deactivate() => Console.WriteLine($"[{Name}] - DEACTICATE (Rest)");
        public virtual void Flicker() => Console.WriteLine($"[{Name}] - It starts blinking randomly, creating panic!");
        public virtual void PlayAmbience() => Console.WriteLine($"[{Name}] Fills the space with an oppressive hum");

        public abstract void PerformUniqueEffect();

        public void Execute(params ArenaAction[] actions)
        {
            foreach (var action  in actions)
            {
                switch (action)
                {
                    case ArenaAction.ACTIVATE: Activate(); break;
                    case ArenaAction.DEACTIVATE: Deactivate(); break;
                    case ArenaAction.FLICKER: Flicker(); break;
                    case ArenaAction.PLAY_AMBIENCE: PlayAmbience(); break;
                    case ArenaAction.STANBY: PerformUniqueEffect(); break;
                }
            }
        }
    }
}
