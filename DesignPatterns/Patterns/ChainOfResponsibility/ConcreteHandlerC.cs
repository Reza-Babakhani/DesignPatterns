using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    internal class ConcreteHandlerC:Handler
    {
        public ConcreteHandlerC(Handler next) : base(next)
        {
        }

        protected override bool doHandle(PipelineRequest req)
        {
            Console.WriteLine("Handling C: "+req.getData());
            return true;
        }
    }
}
