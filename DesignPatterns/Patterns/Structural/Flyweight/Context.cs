namespace DesignPatterns.Patterns.Structural.Flyweight
{
	internal class Context
	{
		public int UniqueState1 { get; set; }

		public string UniqueState2 { get; set; }


		public Flyweight flyweight { get; set; }

		public Context(int UniqueState1, string UniqueState2, Flyweight flyweight)
		{
			this.UniqueState1 = UniqueState1;
			this.UniqueState2 = UniqueState2;

			this.flyweight = flyweight;
		}

	}
}
