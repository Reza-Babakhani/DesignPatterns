namespace DesignPatterns.Patterns.Behavioral.Strategy
{
	internal class ConcreteStrategyA : IStrategy
	{
		public void doSomething()
		{
			Console.WriteLine("doing A");
		}
	}
}
