using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Adapter
{
    class Adapter : ICar
    {
        IPlane plane;
        public Adapter(IPlane plane) {
            this.plane = plane;
        }
        public void Move()
        {
            plane.Fly();
        }
    }
}
