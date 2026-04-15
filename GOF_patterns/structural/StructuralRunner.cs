using GOF_patterns.creational.builder;
using GOF_patterns.structural.adapter;
using GOF_patterns.structural.bridge;
using GOF_patterns.structural.composite;
using GOF_patterns.structural.decorator;
using GOF_patterns.structural.facade;
using GOF_patterns.structural.flyweight;
using GOF_patterns.structural.proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural
{
    public class StructuralRunner
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n   --- STRUCTURAL PATTERNS ---");

            Console.WriteLine("\n====== Adapter: Using strange weapons ======");
            var adaptedWeapon = new MusicBoxAdapter();
            var Hero = new HeroAttack(adaptedWeapon);
            Console.WriteLine("[SYSTEM] A monster is approaching, your health is decreasing.");
            Hero.ExecuteAttack();

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Bridge: Pitfalls and types of harm ======");
            Console.WriteLine("Installing a fire trap...");
            var fireSpike = new SpikeTrap(new FireElement());
            fireSpike.Trigger();

            Console.WriteLine();

            Console.WriteLine("Enhancing the trap with toxins...");
            var toxisSpike = new SpikeTrap(new PoisonElement());
            toxisSpike.Trigger();

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Composite: Game map ======");
            var wing = new ArenaSector("West Wing");
            var scientists = new Room("Scientists' Basement");
            var dining = new Room("Dining room");

            wing.Add(scientists);
            wing.Add(dining);

            Console.WriteLine("Player enters the West Wing ---");
            Console.WriteLine("Peeks through the camera hole");
            dining.Reveal();
            wing.DisplayMap(0);

            Console.WriteLine("\n The player turns on the main switch of the Wing! ---");
            wing.Reveal();
            wing.DisplayMap(0);

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Decorator: Hero status ======");
            IHero hero = new BaseHero();
            Console.WriteLine("Status hero: ");
            Console.WriteLine($"{hero.GetStatus()} | Health: {hero.GetHealth()} | Speed: {hero.GetSpeed()}");

            hero = new FearDecorator(hero);
            Console.WriteLine($"After meeting the Mirror: {hero.GetStatus()} | Health: {hero.GetHealth()}");

            hero = new AdrenalineDecorator(hero);
            Console.WriteLine($"After injection: {hero.GetStatus()} | Health: {hero.GetHealth()} | Speed: {hero.GetSpeed()}");

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Facade: Changing the game theme ======");
            var arena = new HorrorArenaFacade();
            arena.TriggerAmbientMode();

            Console.WriteLine("\n...Suddenly the door opened, and in the passage to the center stands a mirror scientist...");
            arena.BossAwakeningMode();

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Flyweight: Horde of monsters ======");
            var factory = new MonsterFactory();
            var horde = new Horde(factory);

            horde.SetTarget(MonsterType.MirrorHuman, "Bai Liu");
            horde.SetTarget(MonsterType.Shadow, "Music Box");

            horde.Update();

            //=================================================================================================
            Console.WriteLine();

            Console.WriteLine("\n====== Proxy: Boss from another game ======");
            IArenaWorld demonicPortal = new PortalProxy();
            Console.WriteLine("--- THE EVIL GOD CALLS FOR SHADOWS TO ATTACK ---");
            demonicPortal.EnterWorld(new ShadowServant("First Shadow"));
            demonicPortal.EnterWorld(new ShadowServant("Second Shadow"));
            demonicPortal.EnterWorld(new ShadowServant("Third Shadow"));
            demonicPortal.EnterWorld(new ShadowServant("Fourth Shadow"));
        }
    }
}
