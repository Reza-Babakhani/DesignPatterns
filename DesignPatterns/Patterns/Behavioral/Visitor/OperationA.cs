namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	internal class OperationA : IOperation
	{
		public void Visit(ElementA a)
		{
			Console.WriteLine("Doing OperationA on ElementA");
		}

		public void Visit(ElementB b)
		{
			Console.WriteLine("Doing OperationA on ElementB");
		}

		public void Visit(ElementC c)
		{
			Console.WriteLine("Doing OperationA on ElementC");
		}
	}
}
