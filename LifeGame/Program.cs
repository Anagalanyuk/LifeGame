using System;

using System.Text;

namespace LifeGame
{
	internal class Program
	{
		internal static void Main(string[] parametrs)
		{
			if (parametrs.Length != 0)
			{
				StringBuilder delay = new StringBuilder();
				StringBuilder height = new StringBuilder();
				StringBuilder weight = new StringBuilder();
				int columns = 0;
				int rows = 0;
				int sleep = 0;
				bool result = true;
				foreach (string parametr in parametrs)
				{
					if (parametr[0] == 'h')
					{
						for (int i = 1; i < parametr.Length; ++i)
						{
							if (parametr[i] < '0' || parametr[i] > '9')
							{
								result = false;
								break;
							}
							else
							{
								height.Append(parametr[i]);
							}
						}
						if (result)
						{
							rows = int.Parse(height.ToString());
						}
					}
					else if (parametr[0] == 's')
					{
						for (int i = 1; i < parametr.Length; ++i)
						{
							if (parametr[i] < '0' || parametr[i] > '9')
							{
								result = false;
								break;
							}
							else
							{
								delay.Append(parametr[i]);
							}
						}
						if (result)
						{
							sleep = int.Parse(delay.ToString());
						}

					}
					else if (parametr[0] == 'w')
					{
						for (int i = 1; i < parametr.Length; ++i)
						{
							if (parametr[i] < '0' || parametr[i] > '9')
							{
								result = false;
								break;
							}
							else
							{
								weight.Append(parametr[i]);
							}
						}
						if (result)
						{
							columns = int.Parse(weight.ToString());
						}
					}
				}
				if (rows > 0 && columns == 0)
				{
					Console.Write("Invalid arguments: ");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("“Widht of the Universe was not specified.");
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
					StartGame threeParametrs = new StartGame(rows, columns, sleep);
					threeParametrs.PlayGame();
				}
				else if (columns != 0 && rows != 0 && sleep == 0)
				{
					StartGame twoParameters = new StartGame(rows, columns);
					twoParameters.PlayGame();
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