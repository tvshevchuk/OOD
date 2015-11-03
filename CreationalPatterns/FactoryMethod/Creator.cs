using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.FactoryMethod
{
    abstract class Creator
    {
        public string Name { get; set; }

        public Creator(string name)
        {
            Name = name;
        }
        public abstract Product Create();
    }
}
