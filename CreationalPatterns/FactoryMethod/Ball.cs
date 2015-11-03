using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.FactoryMethod
{
    class Ball : Product
    {
        public Ball()
        {
            Console.WriteLine("Created soccer ball");
        }
    }
}
