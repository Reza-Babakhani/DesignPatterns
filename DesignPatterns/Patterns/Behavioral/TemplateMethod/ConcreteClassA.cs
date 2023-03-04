namespace DesignPatterns.Patterns.Behavioral.TemplateMethod
{
	internal class ConcreteClassA : AbstractClass
	{
		public ConcreteClassA() : base("A")
		{

		}

		protected override void doExecute()
		{
			Console.WriteLine("Runing A");
		}
	}
}
