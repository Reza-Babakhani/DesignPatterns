namespace DesignPatterns.Patterns.Creational.Builder
{
	internal class Product
	{
		public string OptionA { get; set; }

		public string OptionB { get; set; }

		public string OptionC { get; set; }


		public override string ToString()
		{
			return $"OptionA: {OptionA}, OptionB: {OptionB}, OptionC: {OptionC}";
		}

	}
}
