using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Adapter
{
    class Bus : ICar
    {
        public void Move()
        {
            Console.WriteLine("Drive to the stadium");
        }
    }
}
