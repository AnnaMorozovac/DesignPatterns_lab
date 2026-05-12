using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.observer
{
    public class MagicArtifact : IWallObserver
    {
        public void Update(SecretType secret)
        {
            Console.WriteLine($" -> Artifact: Vibrates in the bag, responding to the energy of {secret}.");
        }
    }
}
