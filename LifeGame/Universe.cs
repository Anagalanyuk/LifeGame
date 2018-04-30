﻿using System;
using System.Collections.Generic;

namespace LifeGame
{
	public sealed class Universe
	{
		int rows;
		int columns;
		private Cell[,] universe;
		List<Universe> history;
		int repeatGeneration = 0;

		public Universe(int rows, int columns)
		{
			history = new List<Universe>();
			if (rows < 0 || columns < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			else
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
			}
		}

		public int GetRows()
		{
			return rows;
		}

		public int GetColumns()
		{
			return columns;
		}

		public List<Universe> GetList()
		{
			return history;
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

		public int SetRepeatGeneration(int item)
		{
			return repeatGeneration = item; 
		}

		public int GetrepeatGenaration()
		{
			return repeatGeneration;
		}

		public void AddrepeatGeneration()
		{
			repeatGeneration += 1;
		}
	}
}