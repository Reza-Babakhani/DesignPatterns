using DesignPatterns.Patterns.Behavioral.Visitor;

namespace DesignPatterns.Demos.Behavioral
{
    internal static class VisitorDemo
    {
        public static void Run()
        {
            ElementA a = new ElementA();

            a.accept(new OperationA());
        }

        public static void RunWithContainerOfElement()
        {
            Container container = new Container();
            container.addElement(new ElementA());
            container.addElement(new ElementB());
            container.addElement(new ElementC());


            container.Execute(new OperationA());

            container.Execute(new OperationB());
        }
    }
}
