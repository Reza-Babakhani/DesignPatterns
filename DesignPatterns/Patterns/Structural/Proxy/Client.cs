namespace DesignPatterns.Patterns.Structural.Proxy
{
	internal class Client
	{
		private IImage _image;

		public Client(IImage image)
		{
			_image = image;
		}

		public void DisplayImage()
		{
			_image.Display();
		}

	}
}
