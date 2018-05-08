﻿using System;

using System.Collections.Generic;

namespace LifeGame
{
	public sealed class StartGame
	{
		private BounderyOfTheUniverse border;
		private Cursor cursor;
		private Generation generation;
		private Show game;
		private PlayGameKey key;
		private Universe universe;
		int sleep = 300;

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
			if (rows < 0 || columns < 0)
			{
				throw new IndexOutOfRangeException();
			}
			else
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
			if (rows < 0 || columns < 0 || sleep < 0)
			{
				throw new IndexOutOfRangeException();
			}
			else
			{
				universe = new Universe(rows, columns);
				border = new BounderyOfTheUniverse(universe.Rows, universe.Columns, '+');
				cursor = new Cursor();
				generation = new Generation();
				game = new Show(universe);
				key = new PlayGameKey(universe, cursor, generation);
				this.sleep = sleep;
			}
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
			moves.Add(new StepUp(universe, cursor));
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
					System.Threading.Thread.Sleep(sleep);
				}
			}
			Console.SetCursorPosition(15, 0);
			Console.WriteLine("Game over");
			Console.SetCursorPosition(0, universe.Rows + 3);
		}
	}
}