namespace DesignPatterns.Patterns.Creational.Prototype
{
	internal class ConcretePrototype : IPrototype
	{
		private string _name;

		public ConcretePrototype(string name)
		{
			_name = name;
		}

		public IPrototype Clone()
		{
			return new ConcretePrototype(_name);
		}

		public string Name { get => _name; set => _name = value; }

	}
}
