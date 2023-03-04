namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	internal class ConcreteHandlerC : Handler
	{
		public ConcreteHandlerC(Handler next) : base(next)
		{
		}

		protected override bool doHandle(PipelineRequest req)
		{
			Console.WriteLine("Handling C: " + req.getData());
			return true;
		}
	}
}
