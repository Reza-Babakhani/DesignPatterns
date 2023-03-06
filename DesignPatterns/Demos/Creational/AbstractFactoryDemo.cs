using DesignPatterns.Patterns.Creational.AbstractFactory;

namespace DesignPatterns.Demos.Creational
{
	internal class AbstractFactoryDemo
	{
		public static void Run()
		{
			IAandBFactory factory = new FirstAandBFactory();
			//IAandBFactory factory = new SecondAandBFactory();

			var a = factory.CreateA();
			a.DoAThings();

			var b = factory.CreateB();
			b.DoBThings();

		}
	}
}
