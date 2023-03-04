namespace DesignPatterns.Patterns.Behavioral.State
{
	internal class Context
	{
		private State currentState;

		public void SetState(State state)
		{
			currentState = state;
		}


		public void Handle()
		{
			currentState.Handle();
		}
	}
}
