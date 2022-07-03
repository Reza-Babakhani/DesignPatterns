using DesignPatterns.Patterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class StateDemo
    {
        public static void Run()
        {
            Context context = new();

            context.SetState(new ConcreteStateA());
            context.Handle();


            context.SetState(new ConcreteStateB());
            context.Handle();

            context.SetState(new ConcreteStateA());
            context.Handle();
        }
    }
}
