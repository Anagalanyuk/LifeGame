using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			universe[cursor.GetY(), cursor.GetX()].ChangeState();
		}

		public ConsoleKey GetArrow() { return arrow; }
	}
}