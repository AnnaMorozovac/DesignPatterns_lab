using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.templatemethod
{
    public class LightReading : WallReadingMethod
    {
        protected override string DecipherMessage()
        {
            Console.WriteLine("[SYSTEM] You bring the lantern closer. The light picks out the barely visible runes....");
            return "SEARCH FOR THE HEART OF THE ARENA";
        }

        protected override void TriggerReaction(string message)
        {
            Console.WriteLine($"[TIP]: '{message}'. You feel more confident.");
        }
    }
}
