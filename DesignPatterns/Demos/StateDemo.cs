using DesignPatterns.Patterns.Behavioral.State;

namespace DesignPatterns.Demos
{
	internal static class StateDemo
	{
		public static void Run()
		{
			Context context = new();

			context.SetState(new ConcreteStateA());
			context.Handle();


			context.SetState(new ConcreteStateB());
			context.Handle();

			context.SetState(new ConcreteStateA());
			context.Handle();
		}
	}
}
