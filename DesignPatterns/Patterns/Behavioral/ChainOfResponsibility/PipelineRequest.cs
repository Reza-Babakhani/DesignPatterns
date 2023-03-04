namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	internal class PipelineRequest
	{

		private string data;

		public void setData(string data)
		{
			this.data = data;
		}

		public string getData()
		{
			return data;
		}
	}
}
