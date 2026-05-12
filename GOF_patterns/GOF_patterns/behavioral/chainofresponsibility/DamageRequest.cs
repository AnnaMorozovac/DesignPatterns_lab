using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.chainofresponsibility
{
    public class DamageRequest
    {
        public int Amount { get; set; }
        public DamageType Type { get; }
        public bool IsMortalMode { get; }
        public bool Handled { get; private set; }

        public DamageRequest(int amount, DamageType type, bool isMortalMode)
        {
            Amount = amount;
            Type = type;
            IsMortalMode = isMortalMode;
        }

        public void MarkHandled() => Handled = true;
    }
}
