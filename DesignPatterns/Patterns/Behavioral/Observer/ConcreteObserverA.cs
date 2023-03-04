namespace DesignPatterns.Patterns.Behavioral.Observer
{
	internal class ConcreteObserverA : Observer
	{
		private ConcreteSubject source;

		public ConcreteObserverA(ConcreteSubject source)
		{
			this.source = source;
			source.attach(this);
		}

		public void Update()
		{
			Console.WriteLine("A updated: " + source.getValue());
		}
	}
}
