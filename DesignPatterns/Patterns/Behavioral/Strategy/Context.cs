namespace DesignPatterns.Patterns.Behavioral.Strategy
{
	internal class Context
	{

		public void Do(IStrategy strategy)
		{
			strategy.doSomething();
		}
	}
}
