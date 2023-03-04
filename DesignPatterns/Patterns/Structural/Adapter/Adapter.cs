using DesignPatterns.Patterns.Structural.Adapter.SomeLibrary;

namespace DesignPatterns.Patterns.Structural.Adapter
{
	internal class Adapter : Target
	{
		private Adaptee adaptee;
		public Adapter(Adaptee adaptee)
		{
			this.adaptee = adaptee;
		}
		public void apply()
		{
			adaptee.run();
		}
	}
}
