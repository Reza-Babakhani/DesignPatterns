namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	internal class ElementB : IElement
	{
		public void accept(IOperation operation)
		{
			operation.Visit(this);
		}
	}
}
