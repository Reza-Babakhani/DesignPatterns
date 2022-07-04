using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Mediator
{
    internal class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(Mediator owner) : base(owner)
        {
        }

        public void Send()
        {
            owner.Change(this);
        }
    }
}
