﻿using System;

namespace LifeGame
{
	public sealed class BounderyOfTheUniverse
	{
		private char border;
		private int height = 1;
		private int length = 2;

		public BounderyOfTheUniverse(int length, int height, char border)
		{
			this.border = border;
			this.height += height;
			this.length += length;
		}

		public void Show()
		{
			for (int upperLowerBounds = 0; upperLowerBounds <= height; ++upperLowerBounds)
			{
				Console.SetCursorPosition(upperLowerBounds, 1);
				Console.Write(border);
				Console.SetCursorPosition(upperLowerBounds, length);
				Console.Write(border);
			}

			for (int leftRightBounds = 2; leftRightBounds <= length; ++leftRightBounds)
			{
				Console.SetCursorPosition(0, leftRightBounds);
				Console.Write(border);
				Console.SetCursorPosition(height, leftRightBounds);
				Console.Write(border);
			}
			Console.WriteLine();
		}
	}
}