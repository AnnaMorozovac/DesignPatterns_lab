using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_patterns.behavioral.chainofresponsibility
{
    public class ArenaDamageProcessor
    {
        private readonly List<IDamageHandler> _handlers;

        public ArenaDamageProcessor(List<IDamageHandler> handlers)
        {
            _handlers = handlers;
        }

        public void ProcessDamage(DamageRequest request)
        {
            Console.WriteLine($"\n Processing {request.Type} damage: {request.Amount}");
            var applicableHandlers = _handlers.Where(h => h.CanHandle(request)).OrderBy(h => h.GetPriority());

            foreach (var handler in applicableHandlers)
            {
                handler.Handle(request);
                if (request.Handled) break;
            }

            Console.WriteLine($"FINAL RESULT: Player receives {request.Amount} damage");
        }
    }
}
