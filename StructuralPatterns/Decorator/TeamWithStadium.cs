using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Decorator
{
    class TeamWithStadium : Decorator
    {
        public TeamWithStadium(Component component)
            : base(component.Name + " with stadium", component) { }

        public override int getValue()
        {
            return this.component.getValue() + 1000000;
        }
    }
}
