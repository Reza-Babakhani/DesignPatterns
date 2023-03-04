namespace DesignPatterns.Patterns.Structural.Flyweight
{
	internal class Flyweight
	{
		public string Name { get; init; }
		public byte[] Data { get; init; }

		public Flyweight(string name, byte[] data)
		{
			this.Name = name;
			this.Data = data;
		}
	}
}
