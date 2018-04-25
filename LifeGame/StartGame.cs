using System;

namespace LifeGame
{
	public class StartGame
	{
		private Generation generation;
		private Universe universe;
		private BounderyOfTheUniverse border;
		private ControlKeys key;
		private Show game;
		private CursorX cursor;

		public StartGame(int rows,int columns)
		{
			generation = new Generation();
			universe = new Universe(rows, columns);
			game = new Show(universe);
			border = new BounderyOfTheUniverse(universe.GetRows(),universe.GetColumns(),'+');
			cursor = new CursorX();
			key = new ControlKeys(universe, cursor);
		}

		public void PlayGame()
		{
			generation.show();
			border.Show();
			game.Print();
			cursor.Show();

			Console.ResetColor();
			while(true)
			{
				Console.SetCursorPosition(0, 14);
				var keyCursor = Console.ReadKey().Key;
				switch (keyCursor)
				{
					case ConsoleKey.LeftArrow:
						{
							game.Print();
							key.StepLeft();
							cursor.Show();
							break;
						}
					case ConsoleKey.RightArrow:
						{
							game.Print();
							key.StepRight();
							cursor.Show();
							break;
						}
					case ConsoleKey.UpArrow:
						{
							game.Print();
							key.StepUp();
							cursor.Show();
							break;
						}
					case ConsoleKey.DownArrow:
						{
							game.Print();
							key.StepDown();
							cursor.Show();
							break;
						}
					case ConsoleKey.Enter:
						{
							key.KeyEnter();
							break;
						}
				}	
			}
		}
	}
}