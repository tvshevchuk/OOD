using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Adapter
{
    class Boing : IPlane
    {
        public void Fly()
        {
            Console.WriteLine("Fly to the stadium");
        }
    }
}
