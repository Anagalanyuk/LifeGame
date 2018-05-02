using System;

namespace LifeGame
{
	public sealed class CursorX
	{
		private char cursor = 'X';
		private int x;
		private int y;


		public int SetX(int x) { return this.x = x; }

		public int GetX() { return x; }

		public int SetY(int y) { return this.y = y; }

		public int GetY() {return y;}

		public void Show()
		{
			int displacementX = 1;
			int displacementY = 3;
			Console.SetCursorPosition(x + displacementX, y + displacementY);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(cursor);
			Console.ResetColor();
		}
	}
}