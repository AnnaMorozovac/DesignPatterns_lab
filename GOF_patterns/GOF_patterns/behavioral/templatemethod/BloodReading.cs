using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.templatemethod
{
    public class BloodReading : WallReadingMethod
    {
        protected override string DecipherMessage()
        {
            Console.WriteLine("[SYSTEM] You run your wounded hand over the stones. Blood fills the cracks...");
            return "THERE IS NO WAY OUT OF HERE";
        }

        protected override void TriggerReaction(string message)
        {
            Console.WriteLine($"[WHISPER] '{message}'. Your fear level is rising, but the path is open.");
        }
    }
}
