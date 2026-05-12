using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.structural.adapter
{
    public class MusicBoxAdapter : IModernWeapon
    {
        private readonly OldMusicBox _musicBox = new OldMusicBox();

        public void Use()
        {
            _musicBox.PlayMusic();
        }
    }

    public class ToyBearAdapter : IModernWeapon
    {
        private readonly ToyBear _toyBear = new ToyBear();

        public ToyBearAdapter(ToyBear toyBear)
        {
            _toyBear = toyBear;
        }

        public void Use()
        {
            _toyBear.AngryBear();
        }
    }
}
