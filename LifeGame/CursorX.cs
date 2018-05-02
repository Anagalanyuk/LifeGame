﻿using System;

namespace LifeGame
{
	public sealed class CursorX
	{
		private char X;
		int positinX;
		int positinY;

		public CursorX()
		{
			X = 'X';
			positinX = 0;
			positinY = 0;
		}

		public int SetX(int x) { return positinX = x; }

		public int GetX() { return positinX; }

		public int SetY(int y) { return positinY = y; }

		public int GetY() { return positinY; }

		public void Show()
		{
			Console.SetCursorPosition(positinX + 1, positinY + 3);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(X);
			Console.ResetColor();
		}
	}
}