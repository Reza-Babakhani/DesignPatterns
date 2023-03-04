namespace DesignPatterns.Patterns.Structural.Decorator
{
	internal class AdditionalDecorator : Component
	{
		private Component component;

		public AdditionalDecorator(Component component)
		{
			this.component = component;
		}

		public void Apply(string data)
		{
			var modified = "++" + data + "++";
			component.Apply(modified);
		}
	}
}
