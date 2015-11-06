using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Decorator
{
    abstract class Component
    {
        public string Name { get; set; }
        
        public Component(string name)
        {
            Name = name;
        }

        public abstract int getValue();
    }
}
