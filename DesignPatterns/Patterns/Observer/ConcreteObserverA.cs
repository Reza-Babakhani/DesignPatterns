using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer
{
    internal class ConcreteObserverA : Observer
    {
       private ConcreteSubject source;

        public ConcreteObserverA(ConcreteSubject source)
        {
            this.source = source;
            source.attach(this);
        }

        public void Update()
        {
            Console.WriteLine("A updated: "+source.getValue());
        }
    }
}
