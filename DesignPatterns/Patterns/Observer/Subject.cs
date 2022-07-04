using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer
{
    internal abstract class Subject
    {

        private List<Observer> observers = new List<Observer>();
        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notify()
        {
            foreach (var obs in observers)
            {
                obs.Update();
            }
        }

    }
}
