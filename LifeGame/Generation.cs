using System;

namespace LifeGame
{
	public sealed class Generation
	{
		private int countGeneration;
		private string generation = "Generetion: ";

		public int Count
		{
			get { return countGeneration; }
		}

		public void AddCountGeneration()
		{
			countGeneration += 1;
		}

		public void Show()
		{
			Console.Write($"{ generation }");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write(countGeneration);
			Console.ResetColor();
		}
	}
}