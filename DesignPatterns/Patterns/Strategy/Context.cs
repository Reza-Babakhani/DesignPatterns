using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Strategy
{
    internal class Context
    {

        public void Do(IStrategy strategy)
        {
            strategy.doSomething();
        }
    }
}
