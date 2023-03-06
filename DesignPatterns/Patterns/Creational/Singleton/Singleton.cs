namespace DesignPatterns.Patterns.Creational.Singleton
{
	internal sealed class Singleton
	{
		public string Property1 { get; set; }


		private static Singleton instance = null;

		private Singleton()
		{
			//Private constructor to prevent other instances from being created
		}

		public static Singleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Singleton();
				}

				return instance;
			}
		}


	}
}
