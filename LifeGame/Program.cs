using System;

namespace LifeGame
{
	internal class Program
	{
		internal static void Main()
		{
			StartGame game = new StartGame(10, 40);
			game.PlayGame();
		}
	}
}