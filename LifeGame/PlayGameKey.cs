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
					    //firs rows
						if (indexRows == 0 && indexColumns <= universe.Columns - 1)
						{
							//left upper corner
							if (indexRows == 0 && indexColumns == 0)
							{
								for (int rows = 0; rows < 2; ++rows)
								{
									for (int columns = 0; columns < 2; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
									}
								}
							}
							//right upper corner
							else if (indexColumns == universe.Columns - 1)
							{
								for (int rows = 0; rows < 2; ++rows)
								{
									for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
									}
								}
							}
							//centr
							else
							{
								for (int rows = indexRows; rows < 2; ++rows)
								{
									for (int columns = indexColumns - 1; columns < indexColumns + 2; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
									}
								}
							}
						}
						//Centr
						else if (indexRows > 0 && indexColumns <= universe.Columns - 1 && indexRows < universe.Rows - 1)
						{
							//first columns 
							if (indexColumns == 0)
							{
								for (int rows = indexRows - 1; rows < indexRows + 2; ++rows)
								{
									for (int columns = 0; columns < 2; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
									}
								}
							}
							//last columns
							else if(indexColumns == universe.Columns - 1)
							{
								for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
								{
									for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
									}
								}
							}
							//centr
							else
							{
								for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
								{
									for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
									}
								}
							}
						}
						//last rows
						else if (indexRows == universe.Rows - 1 && indexColumns >= 0 && indexColumns <= universe.Columns - 1)
						{
							//Left down corner
							if (indexColumns == 0)
							{
								for (int rows = indexRows - 1; rows <= indexRows; ++rows)
								{
									for (int columns = indexColumns; columns <= 1; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
									}
								}
							}
							//right down corner
							else if(indexColumns == universe.Columns - 1)
							{
								for (int rows = indexRows - 1; rows <= indexRows; ++rows)
								{
									for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
									}
								}
							}
							//centr
							else
							{
								for (int rows = indexRows - 1; rows <= indexRows; ++rows)
								{
									for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
									{
										if (clone[rows, columns].Condition == CellCondition.Live)
										{
											countLife += 1;
										}
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