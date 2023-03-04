namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	internal interface IElement
	{
		void accept(IOperation operation);
	}
}
