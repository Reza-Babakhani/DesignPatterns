namespace DesignPatterns.Patterns.Creational.Factory
{
	internal class Product2Factory : Factory
	{
		public override IProduct CreateProduct()
		{
			return new Product2();
		}
	}
}
