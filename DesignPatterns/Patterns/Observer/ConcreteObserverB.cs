using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer
{
    internal class ConcreteObserverB : Observer
    {
        private ConcreteSubject source;

        public ConcreteObserverB(ConcreteSubject source)
        {
            this.source = source;
            source.attach(this);
        }

        public void Update()
        {
            Console.WriteLine("B updated: " + source.getValue());

        }
    }
}
