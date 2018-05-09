using System;

using System.Collections.Generic;

namespace LifeGame
{
	public sealed class StartGame
	{
		private BounderyOfTheUniverse border;
		private Cursor cursor;
		private Show game;
		private Generation generation;
		private PlayGameKey key;
		int sleep = 300;
		private Universe universe;

		public StartGame()
		{
			universe = new Universe();
			border = new BounderyOfTheUniverse(universe.Rows, universe.Columns, '+');
			cursor = new Cursor();
			generation = new Generation();
			game = new Show(universe);
			key = new PlayGameKey(universe, cursor, generation);
		}

		public StartGame(int rows, int columns)
		{
			{
				universe = new Universe(rows, columns);
				border = new BounderyOfTheUniverse(universe.Rows, universe.Columns, '+');
				cursor = new Cursor();
				generation = new Generation();
				game = new Show(universe);
				key = new PlayGameKey(universe, cursor, generation);
			}
		}

		public StartGame(int rows, int columns, int sleep)
		{
			universe = new Universe(rows, columns);
			border = new BounderyOfTheUniverse(universe.Rows, universe.Columns, '+');
			cursor = new Cursor();
			generation = new Generation();
			game = new Show(universe);
			key = new PlayGameKey(universe, cursor, generation);
			this.sleep = sleep;
		}

		public void PlayGame()
		{
			generation.Show();
			border.Show();
			game.Print();
			cursor.Show();
			cursor.Show();
			Console.SetCursorPosition(0, universe.Rows + 3);
			var keyCursor = ConsoleKey.Zoom;
			Console.ResetColor();
			ICollection<IMoves> controlKeys = new List<IMoves>();
			controlKeys.Add(new StepRight(universe, cursor));
			controlKeys.Add(new StepLeft(universe, cursor));
			controlKeys.Add(new StepDown(universe, cursor));
			controlKeys.Add(new StepUp(universe, cursor));
			controlKeys.Add(new KeyEnter(universe, cursor));
			while (keyCursor != ConsoleKey.Spacebar)
			{
				Console.SetCursorPosition(0, universe.Rows + 3);
				keyCursor = Console.ReadKey().Key;
				foreach (IMoves key in controlKeys)
				{
					if (key.Arrow == keyCursor)
					{
						game.Print();
						key.Move();
						cursor.Show();
						break;
					}
				}
			}
			while (universe.RepeatGeneration != (universe.Rows * universe.Columns))
			{
				Console.SetCursorPosition(0, universe.Rows + 3);
				if (keyCursor == ConsoleKey.Spacebar)
				{
					key.KeySpace();
					Console.SetCursorPosition(0, 0);
					generation.Show();
					game.Print();
					Console.SetCursorPosition(0, universe.Rows + 3);
					System.Threading.Thread.Sleep(sleep);
				}
			}
			Console.SetCursorPosition(15, 0);
			Console.WriteLine("Game over");
			Console.SetCursorPosition(0, universe.Rows + 3);
		}
	}
}