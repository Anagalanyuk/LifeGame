using System;

namespace LifeGame
{
	public class StepUp : IMoves
	{
		private ConsoleKey arrow;
		private Cursor cursor;
		private Universe universe;

		public StepUp(Universe universe, Cursor cursor)
		{
			arrow = ConsoleKey.UpArrow;
			this.cursor = cursor;
			this.universe = universe;
		}

		public ConsoleKey Arrow
		{
			get { return arrow; }
		}

		public void Move()
		{
			if (cursor.Y > 0)
			{
				cursor.Y = cursor.Y - 1;
			}
		}
	}
}