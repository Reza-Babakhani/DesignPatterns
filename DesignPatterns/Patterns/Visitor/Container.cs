using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Visitor
{
    internal class Container
    {
        private List<IElement> elements = new List<IElement>();

        public void addElement(IElement element)
        {
            elements.Add(element);
        }

        public void Execute(IOperation operation)
        {
            foreach(var e in elements)
            {
                e.accept(operation);
            }
        }
    }
}
