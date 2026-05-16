using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.functional.factory_method
{
    public static class FactoryMethodRunner
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("-- Testing the functional factor method --");

            GameEngine.RunGameProcess(() => new HospitalGame());
            GameEngine.RunGameProcess(() => new ApocalipseGame());
            GameEngine.RunGameProcess(() => new IceAgeGame());
            GameEngine.RunGameProcess(() => new HauntedHouseGame());
        }
    }
}
