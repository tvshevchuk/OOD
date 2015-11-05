using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.BehaviourPatterns.Strategy
{
    class Player
    {
        public string Name { get; set; }

        public IStrategy Kick { get; set; }

        public Player(string name, IStrategy strategy)
        {
            Name = name;
            Kick = strategy;
        }
    }
}
