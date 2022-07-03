using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.TemplateMethod
{
    internal class ConcreteClassB : AbstractClass
    {
        public ConcreteClassB():base("B")
        {

        }
        protected override void doExecute()
        {
            Console.WriteLine("Runing B");
        }
    }
}
