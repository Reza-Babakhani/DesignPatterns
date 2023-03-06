namespace DesignPatterns.Patterns.Creational.Builder
{
	internal class Director
	{
		private readonly IBuilder _builder;

		public Director(IBuilder builder)
		{
			_builder = builder;
		}

		public void Construct()
		{
			_builder.SetOptionA("Option A");
			_builder.SetOptionB("Option B");
			_builder.SetOptionC("Option C");

		}
	}
}
