namespace DesignPatterns.Patterns.Behavioral.Observer
{
	internal class ConcreteObserverB : Observer
	{
		private ConcreteSubject source;

		public ConcreteObserverB(ConcreteSubject source)
		{
			this.source = source;
			source.attach(this);
		}

		public void Update()
		{
			Console.WriteLine("B updated: " + source.getValue());

		}
	}
}
