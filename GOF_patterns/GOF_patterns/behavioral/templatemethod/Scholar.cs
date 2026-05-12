using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.templatemethod
{
    public class Scholar
    {
        private WallReadingMethod _method;
        public string _name { get; }

        public Scholar(string initialName, WallReadingMethod initialMethood)
        {
            _name = initialName;
            _method = initialMethood;
            _method.Name = _name;
        }

        public void SetMethod(WallReadingMethod method)
        {
            _method = method;
        }

        public void StudyWall(string wallName)
        {
            _method.ReadWhisper(wallName);
        }
    }
}
