using System;

namespace LifeGame
{
	public class StepDown : IMoves
	{
		private Universe universe;
		private Cursor cursor;
		public ConsoleKey arrow;

		public StepDown(Universe universe, Cursor cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.DownArrow;
		}

		public void Move()
		{
			if (cursor.Y < universe.GetRows - 1)
			{
				cursor.Y = cursor.Y + 1;
			}
		}

		public ConsoleKey GetArrow { get { return arrow; } }
	}
}