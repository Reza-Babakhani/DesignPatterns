namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	internal class FirstAandBFactory : IAandBFactory
	{
		public IProductA CreateA()
		{
			return new ProductA1();
		}

		public IProductB CreateB()
		{
			return new ProductB1();
		}
	}
}
