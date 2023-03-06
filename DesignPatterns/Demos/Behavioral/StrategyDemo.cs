using DesignPatterns.Patterns.Behavioral.Strategy;

namespace DesignPatterns.Demos.Behavioral
{
    internal static class StrategyDemo
    {
        public static void Run()
        {
            Context context = new Context();

            context.Do(new ConcreteStrategyA());
            context.Do(new ConcreteStrategyB());

        }
    }
}
