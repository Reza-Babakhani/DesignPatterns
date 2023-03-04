namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	internal interface IOperation
	{
		void Visit(ElementA a);
		void Visit(ElementB b);
		void Visit(ElementC c);

	}
}
