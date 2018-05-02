using System;

namespace LifeGame
{
	public sealed class CursorX
	{
		private char X = 'X';
		private int x;
		private int y;

		public int SetX(int x) { return this.x = x; }

		public int GetX() { return x; }

		public int SetY(int y) { return this.y = y; }

		public int GetY() {return y;}

		public void Show()
		{
			Console.SetCursorPosition(x + 1, y + 3);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(X);
			Console.ResetColor();
		}
	}
}