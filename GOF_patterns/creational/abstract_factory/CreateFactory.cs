using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.creational.abstract_factory
{
    public class HospitalFactory : IThemeFactory
    {
        public IMonsters CreateMonster() => new MutantPatients();
        public IMedicine CreateMedecine() => new Adrenaline();
        public IItems CreateItem() => new BookHistory(); 
    }

    public class ApocalipseFactory : IThemeFactory
    {
        public IMonsters CreateMonster() => new Zombie();
        public IMedicine CreateMedecine() => new Antidote();
        public IItems CreateItem() => new Gun();
    }

    public class IceAgeFactory : IThemeFactory
    {
        public IMonsters CreateMonster() => new MirrorMonster();
        public IMedicine CreateMedecine() => new ParasiticBandage();
        public IItems CreateItem() => new FurCoat();
    }

    public class HauntedHouseFactory : IThemeFactory
    {
        public IMonsters CreateMonster() => new GhostsOfTheServant();
        public IMedicine CreateMedecine() => new BookOfFairyTales();
        public IItems CreateItem() => new Candle();
    }
}
