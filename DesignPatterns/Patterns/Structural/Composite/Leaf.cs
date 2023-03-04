namespace DesignPatterns.Patterns.Structural.Composite
{
	internal class Leaf : Component
	{
		private string _name;
		public Leaf(string name)
		{
			_name = name;
		}

		public void Operation()
		{
			Console.WriteLine("Operation on leaf " + _name);
		}
	}
}
