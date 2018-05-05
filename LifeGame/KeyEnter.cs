using System;

namespace LifeGame
{
	public class KeyEnter : IMoves
	{
		private ConsoleKey arrow;
		private Cursor cursor;
		private Universe universe;

		public KeyEnter(Universe universe, Cursor cursor)
		{
			arrow = ConsoleKey.Enter;
			this.cursor = cursor;
			this.universe = universe;
		}
		public ConsoleKey Arrow
		{
			get { return arrow; }
		}

		public void Move()
		{
			universe[cursor.Y, cursor.X].ChangeState();
		}
	}
}