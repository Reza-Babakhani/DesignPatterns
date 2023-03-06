using DesignPatterns.Patterns.Behavioral.ChainOfResponsibility;

namespace DesignPatterns.Demos.Behavioral
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
