using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.functional.execute_around
{
    public static class ExecuteAroundRunner
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("-- Testing execute around patterns --");

            SafeZone.Use(zone => zone.RestoreHealth().ManageInventory());
        }
    }
}
