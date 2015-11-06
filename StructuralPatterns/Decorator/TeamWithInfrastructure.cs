using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Decorator
{
    class TeamWithInfrastructure : Decorator
    {
        public TeamWithInfrastructure(Component component)
            : base(component.Name + " with infrastructure", component) { }

        public override int getValue()
        {
            return this.component.getValue() + 2000000;
        }
    }
}
