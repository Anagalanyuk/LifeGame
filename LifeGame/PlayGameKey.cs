using System;

namespace LifeGame
{
	public sealed class PlayGameKey
	{
		private Universe universe;
		private Cursor cursor;
		private Generation generation;

		public PlayGameKey(Universe universe, Cursor cursor, Generation generation)
		{
			this.universe = universe;
			this.cursor = cursor;
			this.generation = generation;
		}

		public void KeySpace()
		{
			Universe clone = new Universe();
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
			int countLife = 0;
			if (generation.Count > 1)
			{
				for (int indexRows = 0; indexRows < universe.Rows; ++indexRows)
				{
					for (int indexColumns = 0; indexColumns < universe.Columns; ++indexColumns)
					{
						if (indexRows == 0 && indexColumns == 0)
						{
							for (int rows = 0; rows < 2; ++rows)
							{
								for (int columns = 0; columns < 2; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						// First rows
						else if (indexRows == 0 && indexColumns > 0 && indexRows == 0 && indexColumns < universe.Columns - 1)
						{
							for (int rows = indexRows; rows < 2; ++rows)
							{
								for (int columns = indexColumns - 1; columns < indexColumns + 2; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						// Upper right corner
						else if (indexRows == 0 && indexColumns == universe.Columns - 1)
						{
							for (int rows = 0; rows < 2; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Left first columns
						else if (indexRows > 0 && indexColumns == 0 && indexRows < universe.Rows - 1 && indexColumns == 0)
						{
							for (int rows = indexRows - 1; rows < indexRows + 2; ++rows)
							{
								for (int columns = 0; columns < 2; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Centr
						else if (indexRows > 0 && indexColumns < universe.Columns - 1 && indexRows < universe.Rows - 1 && indexColumns < universe.Columns - 1)
						{
							for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Right last columns
						else if (indexRows > 0 && indexColumns == universe.Columns - 1 && indexRows < universe.Rows - 1 && indexColumns == universe.Columns - 1)
						{
							for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}

							}
						}
						//Lower left corner
						else if (indexRows == universe.Rows - 1 && indexColumns == 0)
						{
							for (int rows = indexRows - 1; rows <= indexRows; ++rows)
							{
								for (int columns = indexColumns; columns <= 1; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Last rows
						else if (indexRows == universe.Rows - 1 && indexColumns > 0 && indexRows == universe.Rows - 1 && indexColumns < universe.Columns - 1)
						{
							for (int rows = indexRows - 1; rows <= indexRows; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Lower right corner
						else if (indexRows == universe.Rows - 1 && indexColumns == universe.Columns - 1)
						{
							for (int rows = indexRows - 1; rows <= indexRows; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
								{
									if (clone[rows, columns].Conditions == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						if (clone[indexRows, indexColumns].Conditions == CellCondition.Death)
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
							if (indexHistory[rows, columns].Conditions == universe[rows, columns].Conditions)
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