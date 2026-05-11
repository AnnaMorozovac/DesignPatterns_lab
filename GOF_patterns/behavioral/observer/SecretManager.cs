using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.observer
{
    public class SecretManager
    {
        private SecretType _currentSecret;
        private readonly List<IWallObserver> _observers = new List<IWallObserver>();

        public void AddObserver(IWallObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Added a new Arena element to observation");
        }

        public void RemoveObserver(IWallObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_currentSecret);
            }
        }

        public void SecretFound(SecretType secret)
        {
            _currentSecret = secret;
            Console.WriteLine($"\n[!] Found in the Arena: {secret}!");
            NotifyObserver();
        }
    }
}
