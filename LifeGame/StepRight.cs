using System;

namespace LifeGame
{
	public class StepRight : IMoves
	{
		private Universe universe;
		private Cursor cursor;
		private ConsoleKey arrow;

		public StepRight(Universe universe, Cursor cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.RightArrow;
		}

		public void Move()
		{
			if (cursor.X < universe.GetColumns - 1)
			{
				cursor.X = cursor.X + 1;
			}
		}

		public ConsoleKey GetArrow { get { return arrow; } }
	}
}