using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.AbstractFactory
{
    class FootballFactory : AbstractFactory
    {
        public override Ball CreateBall()
        {
            return new SoccerBall();
        }

        public override Stadium CreateStadium()
        {
            return new SoccerStadium();
        }
    }
}
