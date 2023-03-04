namespace DesignPatterns.Patterns.Behavioral.Observer
{
	internal class ConcreteSubject : Subject
	{
		private string value;

		public void setValue(string value)
		{
			this.value = value;
			notify();
		}

		public string getValue()
		{
			return value;
		}


	}
}
