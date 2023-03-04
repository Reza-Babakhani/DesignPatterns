namespace DesignPatterns.Patterns.Behavioral.Mediator
{
	internal abstract class Colleague
	{
		protected Mediator owner;
		public Colleague(Mediator owner)
		{
			this.owner = owner;
		}
	}
}
