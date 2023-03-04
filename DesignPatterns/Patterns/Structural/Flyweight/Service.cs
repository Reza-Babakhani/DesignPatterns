namespace DesignPatterns.Patterns.Structural.Flyweight
{
	internal class Service
	{
		private readonly FlyweightFactory _flyweightFactory;

		public Service(FlyweightFactory flyweightFactory)
		{
			_flyweightFactory = flyweightFactory;
		}



		public Context CreateNew(int state1, string state2, string flyweightName)
		{

			Context ctx = new Context(state1, state2, _flyweightFactory.GetFlyweight(flyweightName));

			return ctx;
		}
	}
}
