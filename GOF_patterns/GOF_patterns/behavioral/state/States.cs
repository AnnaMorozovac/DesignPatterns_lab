using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.state
{
    public class ColdState : IMedallionState
    {
        public void OnEncounter(Medallion context)
        {
            Console.WriteLine("The medallion remains icy. There is nothing interesting nearby");
        }

        public string GetDescription() => "Cold Calm";
    }


    public class VibratingState : IMedallionState
    {
        public void OnEncounter(Medallion context)
        {
            Console.WriteLine("The medallion trembles slightly. There is a secret hidden somewhere in the walls!");
        }

        public string GetDescription() => "Alarm vibration";
    }


    public class BurningState : IMedallionState
    {
        public void OnEncounter(Medallion context)
        {
            Console.WriteLine("The medallion burns your chest! You have touched something very powerful.");
        }

        public string GetDescription() => "Burning flame";
    }
}

