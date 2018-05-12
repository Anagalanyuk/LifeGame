using System;

using System.Text;

namespace LifeGame
{
	internal class Program
	{
		internal static void Main(string[] parametres)
		{
			if (parametres.Length != 0)
			{
				int columns = 0;
				int rows = 0;
				int sleep = 0;
				foreach (string parameter in parametres)
				{
					MyParse number = new MyParse(parameter);
					if (number.Marker == 'h')
					{
						rows = number.Parse();
					}
					else if (number.Marker == 's')
					{
						sleep = number.Parse();
					}
					else if (number.Marker == 'w')
					{
						columns = number.Parse();
					}
				}
				if (rows > 0 && columns == 0)
				{
					Console.Write("Invalid arguments: ");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("“Width of the Universe was not specified.");
					Console.ResetColor();
				}
				else if (rows == 0 && columns > 0)
				{
					Console.Write("Invalid arguments: ");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("“Height of the Universe was not specified.");
					Console.ResetColor();
				}
				else if (columns != 0 && rows != 0 && sleep != 0)
				{
					StartGame threeParameters = new StartGame(rows, columns, sleep);
					threeParameters.PlayGame();
				}
				else if (columns != 0 && rows != 0 && sleep == 0)
				{
					StartGame twoParameters = new StartGame(rows, columns);
					twoParameters.PlayGame();
				}
				else if (sleep > 0)
				{
					StartGame oneParameters = new StartGame(sleep);
					oneParameters.PlayGame();
				}
				else
				{
					StartGame byDefault = new StartGame();
					byDefault.PlayGame();
				}
			}
			else
			{
				StartGame game = new StartGame();
				game.PlayGame();
			}
		}
	}
}