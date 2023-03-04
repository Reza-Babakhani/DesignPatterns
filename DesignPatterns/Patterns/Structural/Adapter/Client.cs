namespace DesignPatterns.Patterns.Structural.Adapter
{
	internal class Client
	{
		public void Execute(Target t)
		{
			t.apply();
		}
	}
}
