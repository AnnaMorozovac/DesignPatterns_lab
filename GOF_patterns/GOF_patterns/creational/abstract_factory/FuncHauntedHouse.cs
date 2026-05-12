using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.abstract_factory
{
    public class GhostsOfTheServant : IMonsters
    {
        public string GetName() => "Ghosts of the servant";
        public string Attack() => "Passes through the soul and.. [SYSTEM: Learn more types of monster attack]";
    }

    public class BookOfFairyTales : IMedicine
    {
        public string GetTitle() => "Book of faory tales";
        public string Use() => "Read a few pages to calm your fear.";
    }

    public class Candle : IItems
    {
        public string GetTitle() => "Candle";
        public string Use() => "Fire and light scare away everything that flies.";
    }
}
