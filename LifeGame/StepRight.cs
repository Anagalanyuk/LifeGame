using System;

namespace LifeGame
{
	public class StepRight : IMoves
	{
		private Universe universe;
		private CursorX cursor;
		private ConsoleKey arrow;
		public StepRight(Universe universe, CursorX cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.RightArrow;
		}

		public void Move()
		{
			if (cursor.GetX() < universe.GetColumns() - 1)
			{
				cursor.SetX(cursor.GetX() + 1);
			}
		}

		public ConsoleKey GetArrow() { return arrow; }
	}
}