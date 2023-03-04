namespace DesignPatterns.Patterns.Behavioral.Command.Undoable
{
	internal interface UndoableCommand : Command
	{
		void UnExecute();
	}
}
