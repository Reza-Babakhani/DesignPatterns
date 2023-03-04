namespace DesignPatterns.Patterns.Behavioral.Command.Undoable
{
	internal class SomethingCommand2 : UndoableCommand
	{
		private string prevContent;
		private Reciver2 reciver;//service
		private History history;

		public SomethingCommand2(Reciver2 reciver, History history)
		{
			this.reciver = reciver;
			this.history = history;
		}
		public void Execute()
		{
			prevContent = reciver.getContent();
			reciver.doSomething();
			history.Push(this);
		}

		public void UnExecute()
		{
			reciver.setContent(prevContent);
		}
	}
}
