using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.templatemethod
{
    public abstract class WallReadingMethod
    {
        public string Name { get; set; }

        protected void FocusOnWall(string segment)
        {
            Console.WriteLine($"[!] {Name} looks into the wall segment: '{segment}'...");
        }

        protected abstract string DecipherMessage();

        protected abstract void TriggerReaction(string message);

        public void ReadWhisper(string wallSegment)
        {
            FocusOnWall(wallSegment);
            string message = DecipherMessage();
            TriggerReaction(message); 
        }
    }
}
