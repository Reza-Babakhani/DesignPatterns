using DesignPatterns.Patterns.Creational.Factory;

namespace DesignPatterns.Demos.Creational
{
	internal class FactoryDemo
	{
		public static void Run()
		{
			Factory p1factory = new Product1Factory();
			IProduct product1 = p1factory.CreateProduct();
			product1.DoSomething();

			Factory p2factory = new Product2Factory();
			IProduct product2 = p2factory.CreateProduct();
			product2.DoSomething();
		}
	}
}
