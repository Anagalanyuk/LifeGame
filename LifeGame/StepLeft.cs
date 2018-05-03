using System;

namespace LifeGame
{
	public class StepLeft : IMoves
	{
		private Universe universe;
		private Cursor cursor;
		ConsoleKey arrow;

		public StepLeft(Universe universe, Cursor cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.LeftArrow;
		}

		public void Move()
		{
			if (cursor.X > 0)
			{
				cursor.X = cursor.X - 1;
			}
		}

		public ConsoleKey Arrow { get { return arrow; } }
	}
}