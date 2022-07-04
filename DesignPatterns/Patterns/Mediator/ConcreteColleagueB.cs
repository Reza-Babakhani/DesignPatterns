using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Mediator
{
    internal class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(Mediator owner) : base(owner)
        {
        }

        public void Send()
        {
            owner.Change(this);
        }
    }
}
