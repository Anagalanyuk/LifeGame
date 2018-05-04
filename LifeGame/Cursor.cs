using System;

namespace LifeGame
{
	public sealed class Cursor
	{
		private char cursor = 'X';
		private int x;
		private int y;

		public int X
		{
			get { return x; }
			set { x = value; }
		}

		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public void Show()
		{
			int displacementX = 1;
			int displacementY = 2;
			Console.SetCursorPosition(x + displacementX, y + displacementY);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(cursor);
			Console.ResetColor();
		}
	}
}