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
				StringBuilder delay = new StringBuilder();
				StringBuilder height = new StringBuilder();
				StringBuilder weidth = new StringBuilder();
				int columns = 0;
				int rows = 0;
				int sleep = 0;
				bool result = true;
				foreach (string parameter in parametres)
				{
					if (parameter[0] == 'h')
					{
						for (int i = 1; i < parameter.Length; ++i)
						{
							if (parameter[i] < '0' || parameter[i] > '9')
							{
								result = false;
								break;
							}
							else
							{
								height.Append(parameter[i]);
							}
						}
						if (result)
						{
							rows = int.Parse(height.ToString());
						}
					}
					else if (parameter[0] == 's')
					{
						for (int i = 1; i < parameter.Length; ++i)
						{
							if (parameter[i] < '0' || parameter[i] > '9')
							{
								result = false;
								break;
							}
							else
							{
								delay.Append(parameter[i]);
							}
						}
						if (result)
						{
							sleep = int.Parse(delay.ToString());
						}
					}
					else if (parameter[0] == 'w')
					{
						for (int i = 1; i < parameter.Length; ++i)
						{
							if (parameter[i] < '0' || parameter[i] > '9')
							{
								result = false;
								break;
							}
							else
							{
								weidth.Append(parameter[i]);
							}
						}
						if (result)
						{
							columns = int.Parse(weidth.ToString());
						}
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