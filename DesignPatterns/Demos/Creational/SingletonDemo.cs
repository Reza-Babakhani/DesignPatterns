using DesignPatterns.Patterns.Creational.Singleton;

namespace DesignPatterns.Demos.Creational
{
	internal class SingletonDemo
	{
		public static void Run()
		{
			var obj = Singleton.Instance;

			obj.Property1 = "abcd";

			Console.WriteLine(obj == Singleton.Instance);
		}
	}
}
