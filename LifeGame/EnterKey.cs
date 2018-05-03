using System;

namespace LifeGame
{
	public class KeyEnter : IMoves
	{
		private Universe universe;
		private CursorX cursor;
		private ConsoleKey arrow;

		public KeyEnter(Universe universe, CursorX cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.Enter;
		}

		public void Move()
		{
			universe[cursor.Y, cursor.X].ChangeState();
		}

		public ConsoleKey GetArrow { get { return arrow; } }
	}
}