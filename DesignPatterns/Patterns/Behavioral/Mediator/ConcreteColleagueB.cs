namespace DesignPatterns.Patterns.Behavioral.Mediator
{
	internal class ConcreteColleagueB : Colleague
	{
		public ConcreteColleagueB(Mediator owner) : base(owner)
		{
		}

		public void Send()
		{
			owner.Change(this);
		}
	}
}
