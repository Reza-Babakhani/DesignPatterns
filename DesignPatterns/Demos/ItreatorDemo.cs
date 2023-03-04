using DesignPatterns.Patterns.Behavioral.Iterator;

namespace DesignPatterns.Demos
{
	internal static class ItreatorDemo
	{
		public static void Run()
		{
			Container container = new Container();


			while (container.MoveNext())
			{
				Console.WriteLine(container.Current);
			}
			container.Pop();
			container.Reset();

			while (container.MoveNext())
			{
				Console.WriteLine(container.Current);
			}
		}
	}
}
