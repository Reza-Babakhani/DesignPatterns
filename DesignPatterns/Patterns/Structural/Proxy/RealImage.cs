namespace DesignPatterns.Patterns.Structural.Proxy
{
	internal class RealImage : IImage
	{
		private string _filename;

		public RealImage(string filename)
		{
			_filename = filename;
			LoadFromDisk();
		}

		public void Display()
		{
			Console.WriteLine($"Displaying {_filename}");
		}

		private void LoadFromDisk()
		{
			Console.WriteLine($"Loading {_filename} from disk");
		}

	}
}
