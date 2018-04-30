using System;

namespace LifeGame
{
	public sealed class BounderyOfTheUniverse
	{
		private char border;
		private int length;
		private int height;

		public BounderyOfTheUniverse(int length, int height, char border)
		{
			this.border = border;
			this.length = length + 1;
			this.height = height + 1;
		}

		public void Show()
		{
			for (int topBotton = 0; topBotton <= height; ++topBotton)
			{
				Console.SetCursorPosition(topBotton, 2);
				Console.Write(border);
				Console.SetCursorPosition(topBotton, length + 2);
				Console.Write(border);
			}

			for (int leftRight = 2; leftRight <= length + 1; ++leftRight)
			{
				Console.SetCursorPosition(0 , leftRight);
				Console.Write(border);
				Console.SetCursorPosition(height, leftRight);
				Console.Write(border);
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}