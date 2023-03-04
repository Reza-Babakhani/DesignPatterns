namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	internal class Container
	{
		private List<IElement> elements = new List<IElement>();

		public void addElement(IElement element)
		{
			elements.Add(element);
		}

		public void Execute(IOperation operation)
		{
			foreach (var e in elements)
			{
				e.accept(operation);
			}
		}
	}
}
