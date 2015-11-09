using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.AbstractFactory
{
    class BasketballBall : Ball
    {
        public override void BuyTheBall()
        {
            Console.WriteLine("Buy the basketball ball");
        }
    }
}
