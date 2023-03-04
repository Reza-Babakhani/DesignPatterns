namespace DesignPatterns.Patterns.Structural.Decorator
{
	internal class ConcreteComponent : Component
	{
		public void Apply(string data)
		{
			Console.WriteLine("Applying normal way. data: " + data);
		}
	}
}
