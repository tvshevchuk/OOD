using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Decorator
{
    class FootballTeam : Component
    {
        public FootballTeam()
            : base("Football team") { }

        public override int getValue()
        {
            return 3000000;
        }
    }
}
