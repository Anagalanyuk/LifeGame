using System.Collections.Generic;

namespace LifeGame
{
	public sealed class Universe
	{
		private readonly int  rows = 10;
		private readonly int columns = 40;
		private Cell[,] universe;
		private ICollection<Universe> history = new List<Universe>();
		private int repeatGeneration;

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
		}

		public int GetRows { get { return rows; } }

		public int GetColumns { get { return columns; } }


		public ICollection<Universe> GetHistory { get { return history; } }

		public Cell this[int rows,int columns]
		{
			get { return universe[rows, columns]; }
			set { universe[rows, columns] = value; }
		}

		public int SetRepeatGeneration(int item) { return repeatGeneration = item; }

		public int GetrepeatGenaration { get { return repeatGeneration; } }

		public void AddrepeatGeneration()
		{
			repeatGeneration += 1;
		}
	}
}