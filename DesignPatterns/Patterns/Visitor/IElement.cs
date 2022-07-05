using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Visitor
{
    internal interface IElement
    {
        void accept(IOperation operation);
    }
}
