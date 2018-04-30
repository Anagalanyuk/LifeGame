using System;

namespace LifeGame
{
	public  sealed class StartGame
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
			key = new ControlKeys(universe, cursor,generation);
		}

		public void PlayGame()
		{
			generation.Show();
			border.Show();
			game.Print();
			cursor.Show();
			Console.SetCursorPosition(0, universe.GetRows() + 4);
			var keyCursor = ConsoleKey.Zoom;// = Console.ReadKey().Key;
			Console.ResetColor();
			while (keyCursor != ConsoleKey.Spacebar)
			{
				Console.SetCursorPosition(0, universe.GetRows() + 4);
				keyCursor = Console.ReadKey().Key;
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
			while (true)
			{
				Console.SetCursorPosition(0, universe.GetRows() + 4);
				if (keyCursor == ConsoleKey.Spacebar)
				{
					key.KeySpace();
					Console.SetCursorPosition(0,0);
					generation.Show();
					game.Print();
					Console.SetCursorPosition(0, universe.GetRows() + 4);
					//System.Threading.Thread.Sleep(3000);
					keyCursor = Console.ReadKey().Key;
				}
			}
		}
	}
}