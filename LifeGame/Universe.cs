﻿using System.Collections.Generic;

namespace LifeGame
{
	public sealed class Universe
	{
		private int columns = 40;
		private ICollection<Universe> history;
		private int repeatGeneration;
		private int rows = 10;
		private Cell[,] universe;

		public Universe()
		{
			universe = new Cell[rows, columns];
			for (int i = 0; i < rows; ++i)
			{
				for (int j = 0; j < columns; ++j)
				{
					universe[i, j] = new Cell();
				}
			}
			history = new List<Universe>();
		}
		public Universe(int rows, int columns)
		{
			this.rows = rows;
			this.columns = columns;
			universe = new Cell[rows, columns];
			for (int i = 0; i < rows; ++i)
			{
				for (int j = 0; j < columns; ++j)
				{
					universe[i, j] = new Cell();
				}
			}
			history = new List<Universe>();
		}

		public Cell this[int rows, int columns]
		{
			get { return universe[rows, columns]; }
			set { universe[rows, columns] = value; }
		}

		public int Columns
		{
			get { return columns; }
		}

		public ICollection<Universe> History
		{
			get { return history; }
		}

		public int RepeatGeneration
		{
			get { return repeatGeneration; }
			set { repeatGeneration = value; }
		}

		public int Rows
		{
			get { return rows; }
		}

		public void AddRepeatGeneration()
		{
			repeatGeneration += 1;
		}
	}
}