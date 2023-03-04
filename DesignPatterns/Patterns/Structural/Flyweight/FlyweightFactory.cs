namespace DesignPatterns.Patterns.Structural.Flyweight
{
	internal class FlyweightFactory
	{

		private Dictionary<string, Flyweight> _flyweight = new();


		public Flyweight GetFlyweight(string name)
		{
			if (!_flyweight.ContainsKey(name))
			{
				//just feeding
				_flyweight.Add(name, new Flyweight(name, new byte[] { 1, 2, 3, 4, 5, 6 }));
			}

			return _flyweight[name];
		}

	}
}
