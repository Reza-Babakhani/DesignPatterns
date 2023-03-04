namespace DesignPatterns.Patterns.Behavioral.Command.Undoable
{
	internal class History
	{
		private Stack<UndoableCommand> history = new();

		public void Push(UndoableCommand command)
		{
			history.Push(command);
		}

		public UndoableCommand Pop()
		{
			return history.Pop();
		}
	}
}
