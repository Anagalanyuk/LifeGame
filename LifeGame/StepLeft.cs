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
			if (cursor.X > 0)
			{
				cursor.X = cursor.X - 1;
			}
		}

		public ConsoleKey GetArrow { get { return arrow; } }
	}
}