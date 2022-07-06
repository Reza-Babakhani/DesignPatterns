using DesignPatterns.Patterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class DecoratorDemo
    {
        public static void Run()
        {
            ConcreteComponent component = new ConcreteComponent();

            AdditionalDecorator decorator = new AdditionalDecorator(component);

            decorator.Apply("data");
        }
    }
}
