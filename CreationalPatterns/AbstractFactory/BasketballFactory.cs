using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.AbstractFactory
{
    class BasketballFactory : AbstractFactory
    {
        public override Ball CreateBall()
        {
            return new BasketballBall();
        }

        public override Stadium CreateStadium()
        {
            return new BasketballStadium();
        }
    }
}
