using System;

namespace LifeGame
{
	public sealed class Generation
	{
		private string generation = "Generetion: ";
		private int countGeneration;

		public void AddCountGeneration()
		{
			countGeneration += 1;
		}

		public int GetCount{ get { return countGeneration; } }

		public void Show()
		{
			Console.Write($"{ generation}");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(countGeneration);
			Console.WriteLine();
			Console.ResetColor();
		}
	}
}