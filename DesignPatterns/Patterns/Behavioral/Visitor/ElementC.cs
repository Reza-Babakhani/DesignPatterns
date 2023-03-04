namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	internal class ElementC : IElement
	{
		public void accept(IOperation operation)
		{
			operation.Visit(this);
		}
	}
}
