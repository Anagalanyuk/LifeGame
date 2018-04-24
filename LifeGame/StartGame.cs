using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
	class StartGame
	{
		private Generation generation;
		private Universe universe;
		private BounderyOfTheUniverse border;
		private ControlKeys key;
		private Show game;

		public StartGame(int rows,int columns)
		{
			generation = new Generation();
			universe = new Universe(rows, columns);
			game = new Show(universe);
			border = new BounderyOfTheUniverse(universe.GetRows(),universe.GetColumns(),'+');
			key = new ControlKeys(universe);
		}

		public void PlayGame()
		{
			generation.show();
			border.Show();
			game.Print();
			while(true)
			{
				var keyCursor = Console.ReadKey().Key;
				switch (keyCursor)
				{
					case ConsoleKey.LeftArrow:
						{
							key.StepLeft();
							game.Print();
							break;
						}
					case ConsoleKey.RightArrow:
						{
							key.StepsRight();
							game.Print();
							break;
						}
					case ConsoleKey.UpArrow:
						{
							key.StepUp();
							game.Print();
							break;
						}
					case ConsoleKey.DownArrow:
						{
							key.StepDown();
							game.Print();
							break;
						}
				}	
			}
		}
	}
}
