namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	internal class OperationB : IOperation
	{
		public void Visit(ElementA a)
		{
			Console.WriteLine("Doing OperationB on ElementA");
		}

		public void Visit(ElementB b)
		{
			Console.WriteLine("Doing OperationB on ElementB");
		}

		public void Visit(ElementC c)
		{
			Console.WriteLine("Doing OperationB on ElementC");
		}
	}
}
