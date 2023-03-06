using DesignPatterns.Patterns.Structural.Bridge;

namespace DesignPatterns.Demos.Structural
{
	internal class BridgeDemo
	{

		public static void Run()
		{
			var vectorCircle = new Circle(new VectorRenderer(), 5);
			vectorCircle.Draw(); // Output: Drawing a circle of radius 5 using vector graphics.

			var rasterSquare = new Square(new RasterRenderer(), 10);
			rasterSquare.Draw(); // Output: Drawing a square of side 10 using raster graphics.

		}
	}
}
