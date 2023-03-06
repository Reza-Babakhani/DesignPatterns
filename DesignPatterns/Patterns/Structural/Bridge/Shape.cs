namespace DesignPatterns.Patterns.Structural.Bridge
{
	internal abstract class Shape
	{
		protected IRenderer renderer;

		public Shape(IRenderer renderer)
		{
			this.renderer = renderer;
		}

		public abstract void Draw();

	}
}
