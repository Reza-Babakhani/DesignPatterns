namespace DesignPatterns.Patterns.Behavioral.Mediator
{
	internal class ConcreteColleagueA : Colleague
	{
		public ConcreteColleagueA(Mediator owner) : base(owner)
		{
		}

		public void Send()
		{
			owner.Change(this);
		}
	}
}
