﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Mediator
{
    internal class ConcreteMediator : Mediator
    {
        private ConcreteColleagueA a;
        private ConcreteColleagueB b;

        public void setColleagueA(ConcreteColleagueA a)
        {
            this.a = a;
        }

        public void setColleagueB(ConcreteColleagueB b)
        {
            this.b = b;
        }

        public override void Change(Colleague colleague)
        {
            if (colleague == a)
            {
                Console.WriteLine("Codes when a changes");
            }
            else if(colleague == b)
            {
                Console.WriteLine("Codes when b changes");

            }
        }
    }
}
