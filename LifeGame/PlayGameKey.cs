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
			for (int i = 0; i < universe.GetRows; ++i)
			{
				for (int j = 0; j < universe.GetColumns; ++j)
				{
					clone[i, j] = (Cell)universe[i, j].Clone();
				}
			}
			universe.GetHistory.Add(clone);
			generation.AddCountGeneration();
			Console.SetCursorPosition(0, 0);
			generation.Show();
			int countLife = 0;
			if (generation.GetCount > 1)
			{
				for (int indexRows = 0; indexRows < universe.GetRows; ++indexRows)
				{
					for (int indexColumns = 0; indexColumns < universe.GetColumns; ++indexColumns)
					{
						if (indexRows == 0 && indexColumns == 0)
						{
							for (int rows = 0; rows < 2; ++rows)
							{
								for (int columns = 0; columns < 2; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						// First rows
						else if (indexRows == 0 && indexColumns > 0 && indexRows == 0 && indexColumns < universe.GetColumns - 1)
						{
							for (int rows = indexRows; rows < 2; ++rows)
							{
								for (int columns = indexColumns - 1; columns < indexColumns + 2; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						// Upper right corner
						else if (indexRows == 0 && indexColumns == universe.GetColumns - 1)
						{
							for (int rows = 0; rows < 2; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Left first columns
						else if (indexRows > 0 && indexColumns == 0 && indexRows < universe.GetRows - 1 && indexColumns == 0)
						{
							for (int rows = indexRows - 1; rows < indexRows + 2; ++rows)
							{
								for (int columns = 0; columns < 2; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Centr
						else if (indexRows > 0 && indexColumns < universe.GetColumns - 1 && indexRows < universe.GetRows - 1 && indexColumns < universe.GetColumns - 1)
						{
							for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Right last columns
						else if (indexRows > 0 && indexColumns == universe.GetColumns - 1 && indexRows < universe.GetRows - 1 && indexColumns == universe.GetColumns - 1)
						{
							for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}

							}
						}
						//Lower left corner
						else if (indexRows == universe.GetRows - 1 && indexColumns == 0)
						{
							for (int rows = indexRows - 1; rows <= indexRows; ++rows)
							{
								for (int columns = indexColumns; columns <= 1; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Last rows
						else if (indexRows == universe.GetRows - 1 && indexColumns > 0 && indexRows == universe.GetRows - 1 && indexColumns < universe.GetColumns - 1)
						{
							for (int rows = indexRows - 1; rows <= indexRows; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						//Lower right corner
						else if (indexRows == universe.GetRows - 1 && indexColumns == universe.GetColumns - 1)
						{
							for (int rows = indexRows - 1; rows <= indexRows; ++rows)
							{
								for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
								{
									if (clone[rows, columns].GetCell == CellCondition.Live)
									{
										countLife += 1;
									}
								}
							}
						}
						if (clone[indexRows, indexColumns].GetCell == CellCondition.Death)
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
			if (generation.GetCount > 1)
			{
				foreach (Universe indexHistory in universe.GetHistory)
				{
					universe.SetRepeatGeneration(0);
					for (int rows = 0; rows < universe.GetRows; ++rows)
					{
						for (int columns = 0; columns < universe.GetColumns; ++columns)
						{
							if (indexHistory[rows, columns].GetCell == universe[rows, columns].GetCell)
							{
								universe.AddRepeatGeneration();
							}
						}
					}
					Console.SetCursorPosition(0, universe.GetRows + 4);
					Console.WriteLine(universe.GetRepeatGenaration);
				}
			}
		}
	}
}