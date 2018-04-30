using System;

namespace LifeGame
{
	public sealed class ControlKeys
	{
		private Universe universe;
		private CursorX cursor;
		private Generation generation;

		public ControlKeys(Universe universe, CursorX cursor, Generation generation)
		{
			this.universe = universe;
			this.cursor = cursor;
			this.generation = generation;
		}

		public void StepLeft()
		{
			if (cursor.GetX() > 0)
			{
				cursor.SetX(cursor.GetX() - 1);
			}
		}

		public void StepRight()
		{
			if(cursor.GetX() < universe.GetColumns() - 1)
			{
				cursor.SetX(cursor.GetX() + 1);
			}
		}

		public void StepUp()
		{
			if(cursor.GetY() > 0)
			{
				cursor.SetY(cursor.GetY() - 1);
			}
		}

		public void StepDown()
		{
			if( cursor.GetY() < universe.GetRows() - 1)
			{
				cursor.SetY(cursor.GetY() + 1);
			}
		}

		public void KeyEnter()
		{
				universe[cursor.GetY(), cursor.GetX()].ChancheState();
		}

		public void KeySpace()
		{
			if (universe.GetrepeatGenaration() != universe.GetRows() * universe.GetColumns())
			{
				universe.GetList().Add(new Universe(universe.GetRows(), universe.GetColumns()));
				for (int i = 0; i < universe.GetRows(); ++i)
				{
					for (int j = 0; j < universe.GetColumns(); ++j)
					{
						universe.GetList()[generation.GetCount()][i, j] = (Cell)universe[i, j].Clone();
					}
				}
				generation.AddCountGeneration();
				Console.SetCursorPosition(0, 0);
				generation.Show();
				int countLife = 0;
				if (generation.GetCount() > 1)
				{
					for (int indexRows = 0; indexRows < universe.GetRows(); ++indexRows)
					{
						for (int indexColumns = 0; indexColumns < universe.GetColumns(); ++indexColumns)
						{
							//Upper left corner
							if (universe.GetList()[generation.GetCount() - 1][indexRows, indexColumns].GetCell() == CellCondition.Death)
							{
								if (indexRows == 0 && indexColumns == 0)
								{
									for (int rows = 0; rows < 2; ++rows)
									{
										for (int columns = 0; columns < 2; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								// First rows
								else if (indexRows == 0 && indexColumns > 0 && indexRows == 0 && indexColumns < universe.GetColumns() - 1)
								{
									for (int rows = indexRows; rows < 2; ++rows)
									{
										for (int columns = indexColumns - 1; columns < indexColumns + 2; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								// Upper right corner
								else if (indexRows == 0 && indexColumns == universe.GetColumns() - 1)
								{
									for (int rows = 0; rows < 2; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Left first columns
								else if (indexRows > 0 && indexColumns == 0 && indexRows < universe.GetRows() - 1 && indexColumns == 0)
								{
									for (int rows = indexRows - 1; rows < indexRows + 2; ++rows)
									{
										for (int columns = 0; columns < 2; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Centr
								else if (indexRows > 0 && indexColumns < universe.GetColumns() - 1 && indexRows < universe.GetRows() - 1 && indexColumns < universe.GetColumns() - 1)
								{
									for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Right last columns
								else if (indexRows > 0 && indexColumns == universe.GetColumns() - 1 && indexRows < universe.GetRows() - 1 && indexColumns == universe.GetColumns() - 1)
								{
									for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}

									}
								}
								//Lower left corner
								else if (indexRows == universe.GetRows() - 1 && indexColumns == 0)
								{
									for (int rows = indexRows - 1; rows <= indexRows; ++rows)
									{
										for (int columns = indexColumns; columns <= 1; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Last rows
								else if (indexRows == universe.GetRows() - 1 && indexColumns > 0 && indexRows == universe.GetRows() - 1 && indexColumns < universe.GetColumns() - 1)
								{
									for (int rows = indexRows - 1; rows <= indexRows; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Lower right corner
								else if (indexRows == universe.GetRows() - 1 && indexColumns == universe.GetColumns() - 1)
								{
									for (int rows = indexRows - 1; rows <= indexRows; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								if (countLife == 3)
								{
									universe[indexRows, indexColumns].ChancheState();
								}
								countLife = 0;
							}
							else
							{
								//Upper left corner
								if (indexRows == 0 && indexColumns == 0)
								{
									for (int rows = 0; rows <= 1; ++rows)
									{
										for (int columns = 0; columns <= 1; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								// First rows
								else if (indexRows == 0 && indexColumns > 0 && indexRows == 0 && indexColumns < universe.GetColumns() - 1)
								{
									for (int rows = indexRows; rows < 2; ++rows)
									{
										for (int columns = indexColumns - 1; columns < indexColumns + 2; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								// Upper right corner
								else if (indexRows == 0 && indexColumns == universe.GetColumns() - 1)
								{
									for (int rows = 0; rows < 2; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Left first columns
								else if (indexRows > 0 && indexColumns == 0 && indexRows < universe.GetRows() - 1 && indexColumns == 0)
								{
									for (int rows = indexRows - 1; rows < indexRows + 2; ++rows)
									{
										for (int columns = 0; columns < 2; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Centr
								else if (indexRows > 0 && indexColumns < universe.GetColumns() - 1 && indexRows < universe.GetRows() - 1 && indexColumns < universe.GetColumns() - 1)
								{
									for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Right last columns
								else if (indexRows > 0 && indexColumns == universe.GetColumns() - 1 && indexRows < universe.GetRows() - 1 && indexColumns == universe.GetColumns() - 1)
								{
									for (int rows = indexRows - 1; rows <= indexRows + 1; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}

									}
								}
								//Lower left corner
								else if (indexRows == universe.GetRows() - 1 && indexColumns == 0)
								{
									for (int rows = indexRows - 1; rows <= indexRows; ++rows)
									{
										for (int columns = indexColumns; columns <= 1; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Last rows
								else if (indexRows == universe.GetRows() - 1 && indexColumns > 0 && indexRows == universe.GetRows() - 1 && indexColumns < universe.GetColumns() - 1)
								{
									for (int rows = indexRows - 1; rows <= indexRows; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns + 1; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								//Lower right corner
								else if (indexRows == universe.GetRows() - 1 && indexColumns == universe.GetColumns() - 1)
								{
									for (int rows = indexRows - 1; rows <= indexRows; ++rows)
									{
										for (int columns = indexColumns - 1; columns <= indexColumns; ++columns)
										{
											if (universe.GetList()[generation.GetCount() - 1][rows, columns].GetCell() == CellCondition.Live)
											{
												countLife += 1;
											}
										}
									}
								}
								if (countLife < 3 || countLife > 4)
								{
									universe[indexRows, indexColumns].ChancheState();
								}
								countLife = 0;
							}
						}
					}
				}
			}
			else
			{
				Console.SetCursorPosition(15, 0);
				Console.WriteLine("Game over");
			}
			if(generation.GetCount() > 1)
			{
				for (int indexGeneration = 0; indexGeneration < generation.GetCount(); ++indexGeneration)
				{
					universe.SetRepeatGeneration(0);
					for (int rows = 0; rows < universe.GetRows(); ++rows)
					{
						for (int columns = 0; columns < universe.GetColumns(); ++columns)
						{
							if(universe.GetList()[indexGeneration][rows, columns].GetCell() == universe[rows, columns].GetCell())
							{
								universe.AddrepeatGeneration();
							}
						}
					}
					if (universe.GetrepeatGenaration() == universe.GetRows() * universe.GetColumns())
					{
						indexGeneration = generation.GetCount();
					}
				}
			}
		}
	}
}