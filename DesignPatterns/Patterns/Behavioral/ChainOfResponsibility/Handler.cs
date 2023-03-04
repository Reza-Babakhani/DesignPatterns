namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	internal abstract class Handler
	{
		private Handler next;

		public Handler(Handler next)
		{
			this.next = next;
		}

		public void handle(PipelineRequest req)
		{
			if (doHandle(req))
				return;

			if (next != null)
				next.handle(req);
		}

		protected abstract bool doHandle(PipelineRequest req);
	}
}
