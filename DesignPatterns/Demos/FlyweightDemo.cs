using DesignPatterns.Patterns.Structural.Flyweight;

namespace DesignPatterns.Demos
{
	internal static class FlyweightDemo
	{
		public static void Run()
		{
			Service service = new Service(new FlyweightFactory());

			var ctx1 = service.CreateNew(1, "abc", "t1");

			var ctx2 = service.CreateNew(1, "abc", "t2");

			var ctx3 = service.CreateNew(1, "abc", "t1");

			Console.WriteLine("flyweight object is same in ctx1 and ctx3. HashCodes of both are Equal");
			Console.WriteLine(ctx1.flyweight.GetHashCode().Equals(ctx3.flyweight.GetHashCode()));

		}
	}
}
