using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.BehaviourPatterns.Observer
{
    class Player : IObserver
    {
        IObservable team;
        public string Name { get; set; }

        public Player(string name, IObservable observable)
        {
            Name = name;
            team = observable;
            team.AddObserver(this);
        }

        public void Update(int salary)
        {
            Console.WriteLine("Player {0} gets salary {1}", Name, salary);
        }
    }
}
