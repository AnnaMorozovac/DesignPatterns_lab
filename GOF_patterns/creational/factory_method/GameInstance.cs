using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.factory_method
{
    public class HospitalGame : IGameInstance
    {
        public string Title => "Hospital. Creator of man";
        public void StartInstance() => Console.WriteLine("[!] Loading: Dark corridors, gurneys, the smell of medicine...");
    }

    public class ApocalipseGame : IGameInstance
    {
        public string Title => "World Apocalipse";
        public void StartInstance() => Console.WriteLine("[!] Loading: Ruins of skyscrapers, abandoned cars, sirens...");
    }

    public class IceAgeGame : IGameInstance
    {
        public string Title => "Ice Age";
        public void StartInstance() => Console.WriteLine("[!] Loading: The cold is piercing, the ice is freezing, there is snow everywhere...");
    }

    public class HauntedHouseGame : IGameInstance
    {
        public string Title => "Haunted House";
        public void StartInstance() => Console.WriteLine("[!] Loading: An old house, a sea of ​​dust, myths about a dead wife...");
    }
}
