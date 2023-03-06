namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	internal class SecondAandBFactory : IAandBFactory
	{
		public IProductA CreateA()
		{
			return new ProductA2();
		}

		public IProductB CreateB()
		{
			return new ProductB2();
		}
	}
}
