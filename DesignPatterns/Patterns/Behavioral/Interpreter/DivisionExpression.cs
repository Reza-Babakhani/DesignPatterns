namespace DesignPatterns.Patterns.Behavioral.Interpreter
{
	internal class DivisionExpression : IExpression
	{
		private readonly IExpression _leftExpression;
		private readonly IExpression _rightExpression;

		public DivisionExpression(IExpression leftExpression, IExpression rightExpression)
		{
			_leftExpression = leftExpression;
			_rightExpression = rightExpression;
		}

		public int Interpret()
		{
			var leftOperand = _leftExpression.Interpret();
			var rightOperand = _rightExpression.Interpret();
			return leftOperand / rightOperand;
		}

	}
}
