using DesignPatterns.Patterns.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class MediatorDemo
    {
        public static void Run()
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleagueA a = new ConcreteColleagueA(mediator);
            ConcreteColleagueB b = new ConcreteColleagueB(mediator);
            mediator.setColleagueA(a);
            mediator.setColleagueB(b);

            a.Send();
            b.Send();

        }

    }
}
