using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.TemplateMethod
{
    internal class ConcreteClassA : AbstractClass
    {
        public ConcreteClassA():base("A")
        {

        }

        protected override void doExecute()
        {
            Console.WriteLine("Runing A");
        }
    }
}
