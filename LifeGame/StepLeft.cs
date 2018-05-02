using System;

namespace LifeGame
{
	public class StepLeft : IMoves
	{
		private Universe universe;
		private CursorX cursor;
		ConsoleKey arrow;

		public StepLeft(Universe universe, CursorX cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.LeftArrow;
		}

		public void Move()
		{
			if (cursor.GetX() > 0)
			{
				cursor.SetX(cursor.GetX() - 1);
			}
		}

		public ConsoleKey GetArrow() { return arrow; }
	}
}