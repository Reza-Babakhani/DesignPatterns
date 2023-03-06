using DesignPatterns.Patterns.Behavioral.Interpreter;

namespace DesignPatterns.Demos.Behavioral
{
	internal class InterpreterDemo
	{
		public static void Run()
		{
			// Create the expression tree: ((3 + (4 * 5)) - (6 / 2))
			var expression = new SubtractExpression(
				new AddExpression(
					new NumberExpression(3),
					new MultiplicationExpression(
						new NumberExpression(4),
						new NumberExpression(5))),
				new DivisionExpression(
					new NumberExpression(6),
					new NumberExpression(2)));

			// Evaluate the expression
			var result = expression.Interpret();
			Console.WriteLine($"Result: {result}");

		}
	}
}
