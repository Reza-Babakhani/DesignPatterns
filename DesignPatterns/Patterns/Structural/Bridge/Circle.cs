namespace DesignPatterns.Patterns.Structural.Bridge
{
	internal class Circle : Shape
	{
		private float radius;

		public Circle(IRenderer renderer, float radius) : base(renderer)
		{
			this.radius = radius;
		}

		public override void Draw()
		{
			renderer.RenderCircle(radius);
		}

	}
}
