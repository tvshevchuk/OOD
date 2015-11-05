using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.BehaviourPatterns.Strategy
{
    class KneeKick : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Knee kick");
        }
    }
}
