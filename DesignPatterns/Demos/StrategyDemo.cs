using DesignPatterns.Patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class StrategyDemo
    {
        public static void Run()
        {
            Context context = new Context();

            context.Do(new ConcreteStrategyA());
            context.Do(new ConcreteStrategyB());

        }
    }
}
