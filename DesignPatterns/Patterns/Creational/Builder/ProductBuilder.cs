namespace DesignPatterns.Patterns.Creational.Builder
{
	internal class ProductBuilder : IBuilder
	{
		private Product _product = new Product();
		public Product GetResult()
		{
			return _product;
		}

		public void SetOptionA(string optionA)
		{
			_product.OptionA = optionA;
		}

		public void SetOptionB(string optionB)
		{
			_product.OptionB = optionB;
		}

		public void SetOptionC(string optionC)
		{
			_product.OptionC = optionC;
		}
	}
}
