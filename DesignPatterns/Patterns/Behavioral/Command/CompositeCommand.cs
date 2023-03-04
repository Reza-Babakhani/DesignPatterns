namespace DesignPatterns.Patterns.Behavioral.Command
{
	internal class CompositeCommand : Command
	{
		List<Command> commands = new List<Command>();

		public void add(Command command)
		{
			commands.Add(command);

		}
		public void Execute()
		{
			foreach (Command command in commands)
			{
				command.Execute();
			}
		}
	}
}
