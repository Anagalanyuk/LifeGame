using System;

using System.Collections.Generic;

namespace LifeGame
{
	public sealed class StartGame
	{
		private Generation generation;
		private Universe universe;
		private BounderyOfTheUniverse border;
		private PlayGameKey key;
		private Show game;
		private Cursor cursor;

		public StartGame()
		{
			generation = new Generation();
			universe = new Universe();
			game = new Show(universe);
			border = new BounderyOfTheUniverse(universe.Rows, universe.Columns, '+');
			cursor = new Cursor();
			key = new PlayGameKey(universe, cursor, generation);
		}

		public void PlayGame()
		{
			generation.Show();
			border.Show();
			game.Print();
			cursor.Show();
			Console.SetCursorPosition(0, universe.Rows + 3);
			var keyCursor = ConsoleKey.Zoom;
			Console.ResetColor();
			ICollection<IMoves> moves = new List<IMoves>();
			moves.Add(new StepRight(universe, cursor));
			moves.Add(new StepLeft(universe, cursor));
			moves.Add(new StepDown(universe, cursor));
			moves.Add(new StepUP(universe, cursor));
			moves.Add(new KeyEnter(universe, cursor));
			while (keyCursor != ConsoleKey.Spacebar)
			{
				Console.SetCursorPosition(0, universe.Rows + 3);
				keyCursor = Console.ReadKey().Key;
				foreach (IMoves index in moves)
				{
					if (index.Arrow == keyCursor)
					{
						game.Print();
						index.Move();
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
					System.Threading.Thread.Sleep(300);
				}
			}
			Console.SetCursorPosition(15, 0);
			Console.WriteLine("Game over");
			Console.SetCursorPosition(0, universe.Rows + 3);
		}
	}
}