using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.state
{
    public class Medallion
    {
        private IMedallionState _state;

        public Medallion()
        {
            _state = new ColdState();
        }

        public void SetState(IMedallionState state)
        {
            this._state = state;
            Console.WriteLine($"[!] Medallion energy changed to: {state.GetDescription()}");
        }

        public void React()
        {
            _state.OnEncounter(this);
        }

        public override string ToString()
        {
            return $"Medallion now: {_state.GetDescription()}";
        }
    }
}
