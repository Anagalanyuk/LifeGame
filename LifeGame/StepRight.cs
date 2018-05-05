using System;

namespace LifeGame
{
	public class StepRight : IMoves
	{
		private ConsoleKey arrow;
		private Cursor cursor;
		private Universe universe;

		public StepRight(Universe universe, Cursor cursor)
		{
			arrow = ConsoleKey.RightArrow;
			this.cursor = cursor;
			this.universe = universe;
		}

		public ConsoleKey Arrow
		{
			get { return arrow; }
		}

		public void Move()
		{
			if (cursor.X < universe.Columns - 1)
			{
				cursor.X = cursor.X + 1;
			}
		}
	}
}