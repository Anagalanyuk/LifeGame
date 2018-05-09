using System;

namespace LifeGame
{
	public sealed class PlayGameKey
	{
		private Cursor cursor;
		private Generation generation;
		private Universe universe;

		public PlayGameKey(Universe universe, Cursor cursor, Generation generation)
		{
			this.cursor = cursor;
			this.generation = generation;
			this.universe = universe;
		}

		public void KeySpace()
		{
			int countLife = 0;
			Universe clone = new Universe(universe.Rows, universe.Columns);
			for (int i = 0; i < universe.Rows; ++i)
			{
				for (int j = 0; j < universe.Columns; ++j)
				{
					clone[i, j] = (Cell)universe[i, j].Clone();
				}
			}
			universe.History.Add(clone);
			generation.AddCountGeneration();
			Console.SetCursorPosition(0, 0);
			generation.Show();
			if (generation.Count > 1)
			{
				for (int indexRows = 0; indexRows < universe.Rows; ++indexRows)
				{
					for (int indexColumns = 0; indexColumns < universe.Columns; ++indexColumns)
					{
						for (int i = indexRows - 1; i <= indexRows + 1; ++i)
						{
							for (int j = indexColumns - 1; j <= indexColumns + 1; ++j)
							{
								if (i >= 0 && j >= 0 && i < universe.Rows && j < universe.Columns)
								{
									if (clone[i, j].Condition == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						if (clone[indexRows, indexColumns].Condition == CellCondition.Death)
						{
							if (countLife == 3)
							{
								universe[indexRows, indexColumns].ChangeState();
							}
							countLife = 0;
						}
						else
						{
							if (countLife < 3 || countLife > 4)
							{
								universe[indexRows, indexColumns].ChangeState();
							}
							countLife = 0;
						}
					}
				}
			}
			if (generation.Count > 1)
			{
				foreach (Universe indexHistory in universe.History)
				{
					universe.RepeatGeneration = 0;

					for (int rows = 0; rows < universe.Rows; ++rows)
					{
						for (int columns = 0; columns < universe.Columns; ++columns)
						{
							if (indexHistory[rows, columns].Condition == universe[rows, columns].Condition)
							{
								universe.AddRepeatGeneration();
							}
						}
					}
					if (universe.RepeatGeneration == universe.Rows * universe.Columns)
					{
						break;
					}
				}
			}
		}
	}
}