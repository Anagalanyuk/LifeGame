using System;

namespace LifeGame
{
	public class Generation
	{
		private string generation = "Generetion: ";
		private int countGeneration = 0;

		public void AddCountGeneration()
		{
			countGeneration += 1;
		}
		public void show()
		{
			Console.Write($"{ generation}");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(countGeneration);
			Console.WriteLine();
			Console.ResetColor();
		}
	}
}