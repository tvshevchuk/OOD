using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.AbstractFactory
{
    class BasketballStadium : Stadium
    {
        public override void GoToTheStatium()
        {
            Console.WriteLine("Go to the basketball square");
        }
    }
}
