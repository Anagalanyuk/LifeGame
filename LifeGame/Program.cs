using System;

namespace LifeGame
{
	internal class Program
	{
		internal static void Main(string[] parametrs)
		{
			StartGame game = new StartGame(10,10);
			game.PlayGame();
		}
	}
}