using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.AbstractFactory
{
    class Team
    {
        Ball ball;
        Stadium stadium;

        public Team(AbstractFactory factory)
        {
            ball = factory.CreateBall();
            stadium = factory.CreateStadium();
        }

        public void BuyTheBall()
        {
            ball.BuyTheBall();
        }

        public void GoToStadium()
        {
            stadium.GoToTheStatium();
        }
    }
}
