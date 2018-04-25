using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
	public class CursorX
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

		public int SetX(int x)
		{
			return positinX = x;
		}

		public int GetX()
		{
			return positinX;
		}

		public int SetY(int y)
		{
			return positinY = y;
		}

		public int GetY()
		{
			return positinY;
		}

		public void StepRight()
		{
			if (positinX < 40)
			{
				positinX += 1;
			}
		}

		public void Show()
		{
			Console.SetCursorPosition(positinX + 1, positinY + 3);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(X);
			Console.ResetColor();
		}
	}
}
