using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract Ball CreateBall();
        public abstract Stadium CreateStadium();
    }
}
