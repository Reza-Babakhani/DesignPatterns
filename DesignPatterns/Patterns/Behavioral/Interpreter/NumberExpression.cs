namespace DesignPatterns.Patterns.Behavioral.Interpreter
{
	//Terminal Expression
	internal class NumberExpression : IExpression
	{
		private readonly int _number;

		public NumberExpression(int number)
		{
			_number = number;
		}

		public int Interpret()
		{
			return _number;
		}

	}
}
