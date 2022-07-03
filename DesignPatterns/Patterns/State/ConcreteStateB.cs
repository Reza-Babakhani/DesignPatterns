using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.State
{
    internal class ConcreteStateB : State
    {
        public void Handle()
        {
            Console.WriteLine("Runing B");
        }
    }
}
