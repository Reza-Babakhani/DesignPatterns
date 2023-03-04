namespace DesignPatterns.Patterns.Structural.Composite
{
	internal class Composite : Component
	{
		private List<Component> components = new List<Component>();

		public void addCommponent(Component component)
		{
			components.Add(component);
		}

		public void Operation()
		{
			foreach (Component component in components)
			{
				component.Operation();
			}
		}
	}
}
