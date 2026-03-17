using System;
using System.Collections.Generic;

namespace GOF_patterns.creational.singleton
{
    public sealed class HorrorArena
    {
        private static HorrorArena _instance;
        private static readonly object _lock = new object();

        private HorrorArena()
        {
            Console.WriteLine("You have entered the Arena of Horrors. I wish you success in your survival.");
        }

        public static HorrorArena GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new HorrorArena();
                    }
                }
            }
            return _instance;
        }
    }
}
