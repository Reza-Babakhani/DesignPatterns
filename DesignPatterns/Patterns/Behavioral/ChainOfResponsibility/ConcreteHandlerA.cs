namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	internal class ConcreteHandlerA : Handler
	{
		public ConcreteHandlerA(Handler next) : base(next)
		{
		}

		protected override bool doHandle(PipelineRequest req)
		{
			Console.WriteLine("Handling A: " + req.getData());
			return false;
		}
	}
}
