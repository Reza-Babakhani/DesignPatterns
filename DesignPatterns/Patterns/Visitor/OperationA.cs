using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Visitor
{
    internal class OperationA : IOperation
    {
        public void Visit(ElementA a)
        {
            Console.WriteLine("Doing OperationA on ElementA");
        }

        public void Visit(ElementB b)
        {
            Console.WriteLine("Doing OperationA on ElementB");
        }

        public void Visit(ElementC c)
        {
            Console.WriteLine("Doing OperationA on ElementC");
        }
    }
}
