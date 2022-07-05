using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Visitor
{
    internal class ElementC:IElement
    {
        public void accept(IOperation operation)
        {
            operation.Visit(this);
        }
    }
}
