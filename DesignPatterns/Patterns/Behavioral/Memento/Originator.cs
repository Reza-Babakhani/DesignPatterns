namespace DesignPatterns.Patterns.Behavioral.Memento
{
	internal class Originator
	{
		private string stateA;
		private string stateB;

		public void setStateA(string stateA) => this.stateA = stateA;
		public void setStateB(string stateB) => this.stateB = stateB;

		public string getStateA() => stateA;
		public string getStateB() => stateB;


		public Memento Save()
		{
			return new(stateA, stateB);
		}


		public void Undo(Memento state)
		{
			stateA = state.getStateA();
			stateB = state.getStateB();

		}

	}
}
