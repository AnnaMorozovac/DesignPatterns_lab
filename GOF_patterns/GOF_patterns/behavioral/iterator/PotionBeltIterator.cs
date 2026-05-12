using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.iterator
{
    public class PotionBeltIterator : IPotionIterator
    {
        private readonly PotionBelt _belt;
        private readonly PotionType _type;
        private int _index;

        public PotionBeltIterator(PotionBelt belt, PotionType type)
        {
            _belt = belt;
            _type = type;
            _index = -1;
        }

        private int FindNextInd()
        {
            var potions = _belt.GetPotions();
            int tempInd = _index;

            while (true)
            {
                tempInd++;
                if (tempInd >= potions.Count)
                {
                    tempInd = -1;
                    break;
                }

                if (_type == PotionType.Any || potions[tempInd]._potionType == _type)
                {
                    break;
                }
            }
            return tempInd;
        }

        public bool HasNext()
        {
            return FindNextInd() != -1;
        }

        public Potion Next()
        {
            _index = FindNextInd();
            if (_index != -1)
            {
                return _belt.GetPotions()[_index];
            }
            return null;
        }
    }
}
