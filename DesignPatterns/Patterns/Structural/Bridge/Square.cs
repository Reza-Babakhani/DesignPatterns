namespace DesignPatterns.Patterns.Structural.Bridge
{
	internal class Square : Shape
	{
		private float side;

		public Square(IRenderer renderer, float side) : base(renderer)
		{
			this.side = side;
		}

		public override void Draw()
		{
			renderer.RenderSquare(side);
		}

	}
}
