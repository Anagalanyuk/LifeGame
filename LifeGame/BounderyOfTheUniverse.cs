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
			for (int upperLowerBounds = 0; upperLowerBounds <= height; ++upperLowerBounds)
			{
				Console.SetCursorPosition(upperLowerBounds, 2);
				Console.Write(border);
				Console.SetCursorPosition(upperLowerBounds, length + 2);
				Console.Write(border);
			}

			for (int leftRightBounds = 2; leftRightBounds <= length + 1; ++leftRightBounds)
			{
				Console.SetCursorPosition(0 , leftRightBounds);
				Console.Write(border);
				Console.SetCursorPosition(height, leftRightBounds);
				Console.Write(border);
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}