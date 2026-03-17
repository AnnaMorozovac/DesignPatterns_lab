using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GOF_patterns.creational.singleton;
using GOF_patterns.creational.factory;
using GOF_patterns.creational.factory_method;
using GOF_patterns.creational.abstract_factory;
using GOF_patterns.creational.builder;
using GOF_patterns.creational.prototype;

namespace GOF_patterns.creational
{
    public static class CreationalRunner
    {
        public static void Run()
        {
            Console.WriteLine("----- HORROR ARENA SIMULATOR -----");
            Console.WriteLine("   --- CREATIONAL PATTERNS ---");

            Console.WriteLine("\n====== Singleton: Arena Setup ======");
            HorrorArena arena = HorrorArena.GetInstance();
            HorrorArena OtherArena = HorrorArena.GetInstance();

            if (ReferenceEquals(arena, OtherArena))
            {
                Console.WriteLine("[SYSTEM] Only one Arena exists. Survivors are in the same nightmare.");
            }

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Simple factory: Game Mode ======");
            var gameMod = GameModefactory.CreateMode(GameModeType.Insanity);
            Console.WriteLine($"[SYSTEM] Received mod: {gameMod.Title}");
            gameMod.ApplyRules();

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Factory method: Create game ======");
            GameSwaper swaper = new IceAgeSwaper();
            swaper.RunGameProcess();

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Abstract factory: Theme content ======");
            IThemeFactory themeFactory = new IceAgeFactory();
            var monsters = themeFactory.CreateMonster();
            var medicine = themeFactory.CreateMedecine();
            var items = themeFactory.CreateItem();

            Console.WriteLine("[SYSTEM] Received a little information about the game: ");
            Console.WriteLine($"Monster in game: {monsters.GetName()}");
            Console.WriteLine($"Attack monster: {monsters.Attack()}");
            Console.WriteLine($"\nUseful things: {items.GetTitle()}");
            Console.WriteLine($"How use item: {items.Use()}");

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Builder: Hero custom ======");
            var oneHero = new Hero.Builder("Bai Liu").WithHealth(97).WithPsychics("Limit state").WithClass("Wanderer").WithWeapon("Whip")
                .AddInventory(medicine.GetTitle()).AddInventory("Sense").AddInventory("Gloves").Build();

            var twoHero = new Hero.Builder("Xie Ta").WithHealth(70).WithPsychics("Disturbed").WithClass("Evil god").WithWeapon("Сross").Build();

            oneHero.ShowStats();
            Console.WriteLine();
            twoHero.ShowStats();

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Prototype: Copy monsters ======");
            MirrorMonsters prototypeMon = new MirrorMonsters(monsters.GetName(), monsters.Attack());
            MirrorMonsters clone = (MirrorMonsters)prototypeMon.Clone();

            Console.WriteLine("[SYSTEM] More monsters have appeared in the game: ");
            clone.ShowMonsterInfo();

            Console.WriteLine();
            if (!ReferenceEquals(prototypeMon, clone))
            {
                Console.WriteLine("Objects are not the same!");
            } 
            if (prototypeMon.Equals(clone))
            {
                Console.WriteLine("Objects are identical!");
            }
        }
    }
}
