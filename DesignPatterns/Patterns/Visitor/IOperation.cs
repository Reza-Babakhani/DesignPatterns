using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Visitor
{
    internal interface IOperation
    {
        void Visit(ElementA a);
        void Visit(ElementB b);
        void Visit(ElementC c);

    }
}
