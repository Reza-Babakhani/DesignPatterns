using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Mediator
{
    internal abstract class Colleague
    {
        protected Mediator owner;
        public Colleague(Mediator owner)
        {
            this.owner = owner;
        }
    }
}
