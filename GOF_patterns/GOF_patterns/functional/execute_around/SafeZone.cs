using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.functional.execute_around
{
    public class SafeZone
    {
        private SafeZone()
        {
            Console.WriteLine("[SYSTEM] -> You enters the Safe Zone. Game paused, environment sounds muted, stamina starts recovering");
        }

        public static void Use(Action<SafeZone> gameBlock)
        {
            SafeZone zone = new SafeZone();
            try
            {
                gameBlock(zone);
            }
            finally
            {
                zone.Leave();
            }
        }

        public SafeZone RestoreHealth()
        {
            Console.WriteLine("[ACTION] -> Wounds are bandaged. Health restored to 100%.");
            return this;
        }

        public SafeZone ManageInventory()
        {
            Console.WriteLine("[ACTION] -> Inventory sorted. Ammo reloaded, useless junk discarded.");
            return this;
        }

        public void Leave()
        {
            Console.WriteLine("[SYSTEM] -> Player leaves the Safe Zone. Monsters alerted, steel doors locked behind, normal sound levels restored.\n");
        }
    }
}
