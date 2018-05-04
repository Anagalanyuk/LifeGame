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
			int cursorPositionX = 1;
			int cursorPositionY = 3;
			char cellLive = '0';
			char cellDeath = ' ';
			for (int i = 0; i < universe.Rows; ++i)
			{
				for (int j = 0; j < universe.Columns; ++j)
				{
					if (universe[i, j].Condition ==  CellCondition.Death)
					{
						Console.SetCursorPosition(cursorPositionX + j, cursorPositionY + i);
						Console.Write(cellDeath);
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(cursorPositionX + j, cursorPositionY + i);
						Console.Write(cellLive);
						Console.ResetColor();
					}
				}
				Console.WriteLine();
			}
			Console.ResetColor();
		}
	}
}