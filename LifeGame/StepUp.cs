using System;

namespace LifeGame
{
	public class StepUP : IMoves
	{
		private Universe universe;
		private CursorX cursor;
		private ConsoleKey arrow;

		public StepUP(Universe universe, CursorX cursor)
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

		public ConsoleKey GetArrow { get { return arrow; } }
	}
}