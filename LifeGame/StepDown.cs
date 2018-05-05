using System;

namespace LifeGame
{
	public class StepDown : IMoves
	{
		private ConsoleKey arrow;
		private Cursor cursor;
		private Universe universe;

		public StepDown(Universe universe, Cursor cursor)
		{
			arrow = ConsoleKey.DownArrow;
			this.cursor = cursor;
			this.universe = universe;
		}

		public ConsoleKey Arrow
		{
			get { return arrow; }
		}

		public void Move()
		{
			if (cursor.Y < universe.Rows - 1)
			{
				cursor.Y = cursor.Y + 1;
			}
		}
	}
}