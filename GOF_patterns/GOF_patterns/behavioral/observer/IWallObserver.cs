using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.observer
{
    public interface IWallObserver
    {
        void Update(SecretType secret);
    }
}
