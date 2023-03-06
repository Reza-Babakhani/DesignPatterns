namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	internal class ProductB1 : IProductB
	{
		public void DoBThings()
		{
			Console.WriteLine("Product B1 Doing...");
		}


	}

	internal class ProductB2 : IProductB
	{
		public void DoBThings()
		{
			Console.WriteLine("Product B2 Doing...");
		}


	}
}
