using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.abstract_factory
{
    public class MutantPatients : IMonsters
    {
        public string GetName() => "Mutant Patients";
        public string Attack() => "Attacks with a rusty syringe and.. [SYSTEM: Learn more types of monster attack]";
    }

    public class Adrenaline : IMedicine
    {
        public string GetTitle() => "Adremaline";
        public string Use() => "Inject the drug. Your running speed will increase!";
    }

    public class BookHistory : IItems
    {
        public string GetTitle() => "Visit history book";
        public string Use() => "By reading the book, you can get hints for passing the game.";
    }
}
