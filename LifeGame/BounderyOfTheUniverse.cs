using System;

namespace LifeGame
{
	public class BounderyOfTheUniverse
	{
		private char border;
		private int length;
		private int height;

		public BounderyOfTheUniverse(int length, int height, char border)
		{
			this.border = border;
			this.length = length + 1;
			this.height = height + 2;
		}

		public void Show()
		{
			for (int topBotton = 0; topBotton <= length; ++topBotton)
			{
				Console.SetCursorPosition(topBotton, 2);
				Console.Write(border);
				Console.SetCursorPosition(topBotton, height + 1);
				Console.Write(border);
			}
			for (int leftRight = 2; leftRight <= height; ++leftRight)
			{
				Console.SetCursorPosition(0 , leftRight);
				Console.Write(border);
				Console.SetCursorPosition(length, leftRight);
				Console.Write(border);
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}