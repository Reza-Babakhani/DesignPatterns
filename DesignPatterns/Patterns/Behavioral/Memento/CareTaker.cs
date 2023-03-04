namespace DesignPatterns.Patterns.Behavioral.Memento
{
	internal class CareTaker
	{
		private List<Memento> mementoList = new();

		public void Push(Memento memento)
		{
			mementoList.Add(memento);
		}

		public Memento Pop()
		{

			var item = mementoList[mementoList.Count - 1];
			mementoList.RemoveAt(mementoList.Count - 1);
			return item;
		}
	}
}
