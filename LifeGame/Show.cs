using System;

namespace LifeGame
{
	public sealed class Show
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
					if(universe[i,j].GetCell() ==  CellCondition.Death)
					{
						Console.SetCursorPosition(x + j, y + i);
						Console.Write(' ');
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(x + j, y + i);
						Console.Write('0');
						Console.ResetColor();
					}
				}
				Console.WriteLine();
			}
			Console.ResetColor();
		}
	}
}