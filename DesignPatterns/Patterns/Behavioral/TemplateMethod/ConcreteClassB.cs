namespace DesignPatterns.Patterns.Behavioral.TemplateMethod
{
	internal class ConcreteClassB : AbstractClass
	{
		public ConcreteClassB() : base("B")
		{

		}
		protected override void doExecute()
		{
			Console.WriteLine("Runing B");
		}
	}
}
