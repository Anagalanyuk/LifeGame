using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
	public class Show
	{
		private Universe universe;

		public Show(Universe universe)
		{
			this.universe = universe;
		}

		public void Print()
		{
			for (int i = 0; i < universe.GetRows(); ++i)
			{
				for (int j = 0; j < universe.GetColumns(); ++j)
				{
					if (universe[i, j].Get() == 'X')
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.SetCursorPosition(i + 1, j + 3);
						Console.Write(universe[i, j]);
						Console.ResetColor();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(i + 1, j + 3);
						Console.Write(universe[i, j]);
					}
				}
				Console.WriteLine();
			}
			Console.ResetColor();
			Console.WriteLine();
		}
	}
}
