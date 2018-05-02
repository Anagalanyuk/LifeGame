using System;

namespace LifeGame
{
	public class StepDown : IMoves
	{
		private Universe universe;
		private CursorX cursor;
		public ConsoleKey arrow;

		public StepDown(Universe universe, CursorX cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.DownArrow;
		}

		public void Move()
		{
			if (cursor.GetY() < universe.GetRows() - 1)
			{
				cursor.SetY(cursor.GetY() + 1);
			}
		}

		public ConsoleKey GetArrow() { return arrow; }
	}
}