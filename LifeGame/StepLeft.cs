using System;

namespace LifeGame
{
	public class StepLeft : IMoves
	{
		private ConsoleKey arrow;
		private Cursor cursor;
		private Universe universe;

		public StepLeft(Universe universe, Cursor cursor)
		{
			arrow = ConsoleKey.LeftArrow;
			this.cursor = cursor;
			this.universe = universe;
		}

		public ConsoleKey Arrow
		{
			get { return arrow; }
		}

		public void Move()
		{
			if (cursor.X > 0)
			{
				cursor.X = cursor.X - 1;
			}
		}
	}
}