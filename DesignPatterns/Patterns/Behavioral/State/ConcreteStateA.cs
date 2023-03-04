namespace DesignPatterns.Patterns.Behavioral.State
{
	internal class ConcreteStateA : State
	{
		public void Handle()
		{
			Console.WriteLine("Runing A");
		}
	}
}
