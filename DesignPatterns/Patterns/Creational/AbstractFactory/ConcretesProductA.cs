namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	internal class ProductA1 : IProductA
	{
		public void DoAThings()
		{
			Console.WriteLine("Product A1 Doing...");
		}


	}

	internal class ProductA2 : IProductA
	{
		public void DoAThings()
		{
			Console.WriteLine("Product A2 Doing...");
		}


	}
}
