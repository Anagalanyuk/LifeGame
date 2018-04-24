using System;

namespace LifeGame
{
	public class Cell
	{
		private char cell;

		public Cell(char cell)
		{
			this.cell = cell;
		}

		public char Set(char cell)
		{
			return this.cell = cell;
		}
		public char Get()
		{
			return cell;
		}

		public override string ToString()
		{
			return cell.ToString();
		}
	}
}