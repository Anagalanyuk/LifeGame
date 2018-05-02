using System;

namespace LifeGame
{
	public sealed class CursorX
	{
		private char X = 'X';
		int positionX;
		int positionY;

		public CursorX()
		{
		}

		public int SetX(int x) { return positionX = x; }

		public int GetX() { return positionX; }

		public int SetY(int y) { return positionY = y; }

		public int GetY() {return positionY;}

		public void Show()
		{
			Console.SetCursorPosition(positionX + 1, positionY + 3);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(X);
			Console.ResetColor();
		}
	}
}