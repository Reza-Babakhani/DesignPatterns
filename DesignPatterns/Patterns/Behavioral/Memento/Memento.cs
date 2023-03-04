namespace DesignPatterns.Patterns.Behavioral.Memento
{
	internal class Memento
	{
		private readonly string stateA;
		private readonly string stateB;

		public Memento(string stateA, string stateB)
		{
			this.stateA = stateA;
			this.stateB = stateB;
		}

		public string getStateA() => stateA;

		public string getStateB() => stateB;
	}
}
