using DesignPatterns.Patterns.Structural.Decorator;

namespace DesignPatterns.Demos.Structural
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
