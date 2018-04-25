using System;

namespace LifeGame
{
	public class Show
	{
		private Universe universe;

		public Show(Universe universe)
		{
			this.universe = universe;
		}

		public void Print()
		{
			int x = 1;
			int y = 3;
			for (int i = 0; i < universe.GetRows(); ++i)
			{
				for (int j = 0; j < universe.GetColumns(); ++j)
				{
					if (universe[i, j].Get() == 'X')
					{
						//Console.SetCursorPosition(1 + i, 3 + j);
						Console.Write(universe[x, y]);
						Console.ResetColor();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(x + j, y + i);
						Console.Write(universe[i, j]);
					}
				}
				Console.WriteLine();
			}
			Console.ResetColor();
			//Console.WriteLine();
		}
	}
}