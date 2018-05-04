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

		public int Rows { get { return rows; } }

		public int Columns { get { return columns; } }


		public ICollection<Universe> History { get { return history; } }

		public Cell this[int rows,int columns]
		{
			get { return universe[rows, columns]; }
			set { universe[rows, columns] = value; }
		}

		public int SetRepeatGeneration { set { repeatGeneration = value; } }

		public int RepeatGenaration { get { return repeatGeneration; } }

		public void AddRepeatGeneration()
		{
			repeatGeneration += 1;
		}
	}
}