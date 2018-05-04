using System;

namespace LifeGame
{
	public class StepUP : IMoves
	{
		private Universe universe;
		private Cursor cursor;
		private ConsoleKey arrow;

		public StepUP(Universe universe, Cursor cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.UpArrow;
		}

		public void Move()
		{
			if (cursor.Y > 0)
			{
				cursor.Y = cursor.Y - 1;
			}
		}

		public ConsoleKey Arrow
		{
			get { return arrow; }
		}
	}
}