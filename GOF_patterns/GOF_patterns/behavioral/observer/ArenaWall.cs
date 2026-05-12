using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.observer
{
    public class ArenaWall : IWallObserver
    {
        public void Update(SecretType secret)
        {
            switch (secret)
            {
                case SecretType.AncientScroll:
                    Console.WriteLine(" -> Wall: Golden runes of ancient languages  appears");
                    break;
                case SecretType.HiddenDoor:
                    Console.WriteLine(" -> Wall: The stones tremble, opening a gap");
                    break;
                case SecretType.BloodMark:
                    Console.WriteLine(" -> Wall: Blood begins to flow down the stones, forming words of warning");
                    break;
            }
        }
    }
}
