namespace DesignPatterns.Patterns.Creational.Factory
{
	internal class Product1Factory : Factory
	{
		public override IProduct CreateProduct()
		{
			return new Product1();
		}
	}
}
