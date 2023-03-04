namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	internal class ConcreteHandlerB : Handler
	{
		public ConcreteHandlerB(Handler next) : base(next)
		{
		}

		protected override bool doHandle(PipelineRequest req)
		{
			req.setData("modified data");
			Console.WriteLine("Handling B");
			return false;
		}
	}
}
