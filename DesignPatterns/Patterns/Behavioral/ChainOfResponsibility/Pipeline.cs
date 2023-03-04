namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	internal class Pipeline
	{
		private Handler handler;

		public Pipeline(Handler handler)
		{
			this.handler = handler;
		}

		public void Execute(PipelineRequest request)
		{
			handler.handle(request);
		}
	}
}
