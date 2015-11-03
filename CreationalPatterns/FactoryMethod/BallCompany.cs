using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.FactoryMethod
{
    class BallCompany : Creator
    {
        public BallCompany(string name)
            : base(name)
        {
        }

        public override Product Create()
        {
            return new Ball();
        }
    }
}
