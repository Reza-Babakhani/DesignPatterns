using DesignPatterns.Patterns.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class ChainOfResponsibilityDemo
    {
        public static void Run()
        {
            ConcreteHandlerC c = new ConcreteHandlerC(null);
            ConcreteHandlerB b = new ConcreteHandlerB(c);
            ConcreteHandlerA a = new ConcreteHandlerA(b);

            Pipeline pipeline = new Pipeline(a);

            PipelineRequest req = new PipelineRequest();
            req.setData("inited data");

            pipeline.Execute(req);
        }
    }
}
