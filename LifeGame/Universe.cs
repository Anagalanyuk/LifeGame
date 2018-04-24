using System;

namespace LifeGame
{
	public class Universe
	{
		int rows;
		int columns;
		private Cell[,] universe;

		public Universe(int rows, int columns)
		{
			this.rows = rows;
			this.columns = columns;
			universe = new Cell[rows, columns];
			for(int i = 0; i < rows; ++i)
			{
				for(int j = 0; j < columns; ++j)
				{
					universe[i, j] = new Cell(' ');
				}
			}
			universe[0, 0].Set('X');
		}

		public int GetRows()
		{
			return rows;
		}

		public int GetColumns()
		{
			return columns;
		}

		public Cell this[int rows,int columns]
		{
			get
			{
				return universe[rows, columns];
			}
			set
			{
				universe[rows, columns] = value;
			}
		}
	}
}