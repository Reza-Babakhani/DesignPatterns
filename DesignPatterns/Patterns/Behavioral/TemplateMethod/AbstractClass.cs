namespace DesignPatterns.Patterns.Behavioral.TemplateMethod
{
	internal abstract class AbstractClass
	{
		private string dependentValue;
		public AbstractClass(string dependentValue)
		{
			this.dependentValue = dependentValue;
		}

		public void TemplateMethod()
		{
			Console.WriteLine($"Template Method Runing {dependentValue}");
			doExecute();
		}

		protected abstract void doExecute();
	}
}
