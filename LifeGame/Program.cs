using System;

namespace LifeGame
{
	internal class Program
	{
		internal static void Main()
		{

			StartGame game = new StartGame(10, 40);
			//Universe game = new Universe(10, 40);
			//Show foo = new Show(game);
			//BounderyOfTheUniverse bord = new BounderyOfTheUniverse(game.GetRows(), game.GetColumns(), '#');
			//bord.Show();
			game.PlayGame();
		}
	}
}