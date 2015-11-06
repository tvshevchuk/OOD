using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Decorator
{
    class BasketballTeam : Component
    {
        public BasketballTeam()
            : base("Basketball team") { }

        public override int getValue()
        {
            return 2000000;
        }
    }
}
