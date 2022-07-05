using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    internal class ConcreteHandlerA : Handler
    {
        public ConcreteHandlerA(Handler next) : base(next)
        {
        }

        protected override bool doHandle(PipelineRequest req)
        {
            Console.WriteLine("Handling A: "+req.getData());
            return false;
        }
    }
}
