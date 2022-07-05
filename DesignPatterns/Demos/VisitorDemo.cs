using DesignPatterns.Patterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
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
