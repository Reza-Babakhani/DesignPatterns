namespace DesignPatterns.Patterns.Behavioral.Command.Undoable
{
	internal class Reciver2
	{
		private string content;

		public void doSomething()
		{
			content = "++" + content + "++";
		}

		public string getContent()
		{
			return content;
		}

		public void setContent(string value)
		{
			content = value;
		}
	}
}
