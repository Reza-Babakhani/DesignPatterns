using DesignPatterns.Patterns.Behavioral.Mediator;

namespace DesignPatterns.Demos
{
	internal static class MediatorDemo
	{
		public static void Run()
		{
			ConcreteMediator mediator = new ConcreteMediator();
			ConcreteColleagueA a = new ConcreteColleagueA(mediator);
			ConcreteColleagueB b = new ConcreteColleagueB(mediator);
			mediator.setColleagueA(a);
			mediator.setColleagueB(b);

			a.Send();
			b.Send();

		}

	}
}
