using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.adapter
{
    public class OldMusicBox
    {
        public void PlayMusic()
        {
            Console.WriteLine("USE MUSIC BOX: A creepy melody starts playing... Monsters are paralyzed by fear!");
        }
    }

    public class ToyBear
    {
        public void AngryBear()
        {
            Console.WriteLine("USE TOY BEAR: The toy bear starts roaring and scares the monsters.");
        }
    }
}