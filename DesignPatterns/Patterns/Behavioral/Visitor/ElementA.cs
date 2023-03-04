namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	internal class ElementA : IElement
	{
		public void accept(IOperation operation)
		{
			operation.Visit(this);
		}
	}
}
