using DesignPatterns.Patterns.Creational.Builder;

namespace DesignPatterns.Demos.Creational
{
	internal class BuilderDemo
	{
		public static void Run()
		{
			var builder = new ProductBuilder();
			var director = new Director(builder);
			director.Construct();

			var product = builder.GetResult();

			Console.WriteLine(product);
		}
	}
}
