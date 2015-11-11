using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.BehaviourPatterns.Observer
{
    class FootballTeam : IObservable
    {
        List<IObserver> observers;

        public FootballTeam()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(100);
            }
        }
    }
}
