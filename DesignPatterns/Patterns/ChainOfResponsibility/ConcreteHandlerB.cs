using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    internal class ConcreteHandlerB:Handler
    {
        public ConcreteHandlerB(Handler next) : base(next)
        {
        }

        protected override bool doHandle(PipelineRequest req)
        {
            req.setData("modified data");
            Console.WriteLine("Handling B");
            return false;
        }
    }
}
