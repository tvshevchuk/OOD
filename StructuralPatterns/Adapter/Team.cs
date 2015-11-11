using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.StructuralPatterns.Adapter
{
    class Team
    {
        public void MoveToTheStadium(ICar car) {
            car.Move();
        }
    }
}
