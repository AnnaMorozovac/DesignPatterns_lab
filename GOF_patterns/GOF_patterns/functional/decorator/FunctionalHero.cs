using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.functional.decorator
{
    public class FunctionalHero
    {
        private Func<string, string> _statusFilter;
        private Func<double, double> _healthFilter;
        private Func<int, int> _speedFilter;

        public FunctionalHero(
            IEnumerable<Func<string, string>> statusEffects = null,
            IEnumerable<Func<double, double>> healthEffects = null,
            IEnumerable<Func<int, int>> speedEffects = null)
        {
            _statusFilter = status => status;
            _healthFilter = health => health;
            _speedFilter = speed => speed;

            if (statusEffects != null)
            {
                foreach (var effect in statusEffects)
                {
                    var current = _statusFilter;
                    _statusFilter = status => effect(current(status));
                }
            }

            if (healthEffects != null)
            {
                foreach (var effect in healthEffects)
                {
                    var current = _healthFilter;
                    _healthFilter = health => effect(current(health));
                }
            }

            if (speedEffects != null)
            { 
                foreach (var effect in speedEffects)
                {
                    var current = _speedFilter;
                    _speedFilter = speed => effect(current(speed));
                }
            }
        }

        public string GetStatus() => _statusFilter("Stable condition");
        public double GetHealth() => _healthFilter(100.0);
        public int GetSpeed() => _speedFilter(10);
    }
}
