using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Decorator
{
    abstract class Decorator : Component
    {
        protected Component component;

        public Decorator(string name, Component component)
            : base(name)
        {
            this.component = component;
        }

    }
}
