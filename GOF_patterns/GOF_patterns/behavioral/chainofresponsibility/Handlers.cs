using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.chainofresponsibility
{
    public class ArmorHandler : IDamageHandler
    {
        public bool CanHandle(DamageRequest request) => request.Type == DamageType.physical;
        public int GetPriority() => 1;
        public string Name() => "Ancient Bone Armor";

        public void Handle(DamageRequest request)
        {
            int reduction = 15;
            request.Amount = Math.Max(0, request.Amount - reduction);
            Console.WriteLine($"[{Name()}] reduced damage by {reduction}. Remaining: {request.Amount}");
        }
    }

    public class MagicShieldHandler : IDamageHandler
    {
        public bool CanHandle(DamageRequest request) => request.Type == DamageType.magical;
        public int GetPriority() => 1;
        public string Name() => "Ethereal Shield";

        public void Handle(DamageRequest request)
        {
            request.Amount /= 2;
            Console.WriteLine($"[{Name()}] absorbed half of  magic energy. Remaining: {request.Amount}");
        }
    }

    public class SurvivalModeHandler : IDamageHandler
    {
        public bool CanHandle(DamageRequest request) => true;
        public int GetPriority() => 10;
        public string Name() => "Survival Mode Controller";

        public void Handle(DamageRequest request)
        {
            if (request.IsMortalMode && request.Amount > 0)
            {
                request.Amount *= 10;
                Console.WriteLine($"[{Name()}] mortal mode active! Damage escalated to {request.Amount}");
            }
            request.MarkHandled();
        }
    }
}
