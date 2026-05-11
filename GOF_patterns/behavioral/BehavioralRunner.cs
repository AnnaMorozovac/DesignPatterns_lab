using GOF_patterns.behavioral.chainofresponsibility;
using GOF_patterns.behavioral.command;
using GOF_patterns.behavioral.iterator;
using GOF_patterns.behavioral.mediator;
using GOF_patterns.behavioral.memento;
using GOF_patterns.behavioral.observer;
using GOF_patterns.behavioral.state;
using GOF_patterns.behavioral.strategy;
using GOF_patterns.behavioral.templatemethod;
using GOF_patterns.behavioral.visitor;
using GOF_patterns.creational.singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral
{
    public class BehavioralRunner
    {
        public static void Run()
        {
            Console.WriteLine("----- HORROR ARENA SIMULATOR -----");
            Console.WriteLine("   --- BEHAVIORAL PATTERNS ---");

            Console.WriteLine("\n====== Chain of responsibility: damage ======");
            var handlers = new List<IDamageHandler>
            {
                new ArmorHandler(), new MagicShieldHandler(), new ArmorHandler()
            };

            var processor = new ArenaDamageProcessor(handlers);

            var req1 = new DamageRequest(50, DamageType.physical, false);
            processor.ProcessDamage(req1);

            var req2 = new DamageRequest(30, DamageType.magical, true);
            processor.ProcessDamage(req2);

            //=================================================================================================
            Console.WriteLine();


            Console.WriteLine("\n====== Command: monster attacks player ======");
            var hero = new Hero("Bai Liu", 100);

            IAttack bite = new BiteCommand(hero, 30);
            IAttack scratch = new ScratchCommand(hero, 50);

            var monster = new MonsterInvoker();

            monster.SetCommand(bite);
            monster.Invoke();
            //=================================================================================================
            Console.WriteLine();


            Console.WriteLine("\n====== Iterator: alchemist's belt ======");
            var belt = new PotionBelt(new List<Potion>()
            {
                new Potion("Healing Brew", PotionType.Healing),
                new Potion("Nightmare Poison", PotionType.Poison),
                new Potion("Ghost Mist", PotionType.Invisibility),
                new Potion("Acid Splash", PotionType.Poison)
            });

            var poisonIterator = belt.GetIterator(PotionType.Poison);

            Console.WriteLine("Searching for poisons in the belt... ");
            while (poisonIterator.HasNext())
            {
                var potion = poisonIterator.Next();
                Console.WriteLine($"Found: {potion._name}");
            }
            
            //=================================================================================================
            Console.WriteLine();



            Console.WriteLine("\n====== Mediator: altar interaction mechanics ======");
            var ritualCitcle = new RitualCircleImpl();
            var blood = new BloodAltar();
            var shadow = new ShadowAltar();

            ritualCitcle.AddAltar(blood);
            ritualCitcle.AddAltar(shadow);

            blood.PerformAction(RitualAction.activated);

            //=================================================================================================
            Console.WriteLine();



            Console.WriteLine("\n====== Memento: mental state ======");
            Stack<HeroSanityMemento> history = new Stack<HeroSanityMemento>();

            var heros = new HeroSanity("Bai Liu", SanityLevel.Calm);
            Console.WriteLine(heros);

            history.Push(heros.GetMemento());
            heros.EncounterHorror(SanityLevel.Anxious);
            history.Push(heros.GetMemento());
            heros.EncounterHorror(SanityLevel.Madness);
            Console.WriteLine(heros);

            Console.WriteLine("[SYSTEM] The hero uses the mind restoration artifact");
            if (history.Count > 0)
            {
                heros.SetMemento(history.Pop());
            }
            Console.WriteLine(heros);
            

            //=================================================================================================
            Console.WriteLine();



            Console.WriteLine("\n====== Obderver: information subscription ======");
            SecretManager secretManager = new SecretManager();

            ArenaWall wesrWall = new ArenaWall();
            MagicArtifact ancientAmulet = new MagicArtifact();

            secretManager.AddObserver(wesrWall);
            secretManager.AddObserver(ancientAmulet);

            secretManager.SecretFound(SecretType.AncientScroll);
            Console.WriteLine("[SYSTEM] Time passes...");

            secretManager.SecretFound(SecretType.BloodMark);
            secretManager.RemoveObserver(ancientAmulet);
            Console.WriteLine("[SYSTEN] The artifact is lost, we find the last secret");
            secretManager.SecretFound(SecretType.HiddenDoor);


            //=================================================================================================
            Console.WriteLine();



            Console.WriteLine("\n====== State: ancient medallion start ======");
            Medallion medallion = new Medallion();
            string name = "Bai Liu";
            Console.WriteLine(medallion);

            medallion.React();

            Console.WriteLine($"[SYSTEM] {name} approaches the wall with a whisper");
            medallion.SetState(new VibratingState());
            medallion.React();

            Console.WriteLine($"[SYSTEM] {name} begins the Bloody Ritual");
            medallion.SetState(new BurningState());
            medallion.React();

            Console.WriteLine($"[SYSTEM] The ritual is complete, the energy has faded");
            medallion.SetState(new ColdState());
            medallion.React();


            //=================================================================================================
            Console.WriteLine();



            Console.WriteLine("\n====== Strategy: hero movement stats ======");
            var heross = new HeroSt("Bai Liu", new CarefulStepStrategy());
            heross.Move();

            Console.WriteLine("\n[SYSTEM] There's a magic trap on the floor ahead");
            heross.ChangeStrategy(new LevitationStrategies());
            heross.Move();

            Console.WriteLine("\n[SYSTEM] It is urgent to escape from the darkness.");
            heross.ChangeStrategy(new MagicDashStrategy());
            heross.Move();

            //=================================================================================================
            Console.WriteLine();



            Console.WriteLine("\n====== Template method: whispering walls secret ======");
            var heroTM = new Scholar("Bai Liu", new LightReading());

            Console.WriteLine("Stage 1: Entrance examination");
            heroTM.StudyWall("East wall near the gate");

            Console.WriteLine("\n[SYSTEM] Circumstances change, it becomes too dark for the lantern");

            heroTM.SetMethod(new BloodReading());
            Console.WriteLine("Stage 2: Exploring the depths");
            heroTM.StudyWall("Altar slab in the center");

            //=================================================================================================
            Console.WriteLine();



            Console.WriteLine("\n====== Visitor: spirit researcher ======");
            var arenaObject = new List<IArenaElement>()
            {
                new Altar(), new Statue(), new Inscription()
            };

            Console.WriteLine("[SYSTEM] The Holy Spirit Appears");
            IResearchVisitor blessing = new BlessingVisitor();
            foreach (var obj in arenaObject)
            {
                obj.Accept(blessing);
            }

            Console.WriteLine("[SYSTEM] The Dark Spirit Appears");
            IResearchVisitor defiler = new DefilerVisitor();
            foreach (var obj in arenaObject)
            {
                obj.Accept(defiler);
            }

            //=================================================================================================
            Console.WriteLine();
        }
    }
}
