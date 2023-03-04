namespace DesignPatterns.Patterns.Behavioral.Command
{
	internal class OtherCommand : Command
	{
		public void Execute()
		{
			Console.WriteLine("Other Command");
		}
	}
}
