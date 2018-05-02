using System;

namespace LifeGame
{
	public sealed  class Cell : ICloneable
	{
		private CellCondition cell; 

		public Cell()
		{
			cell = CellCondition.Death;
		}

		public void ChancheState()
		{
			if (cell == CellCondition.Live)
			{
				cell = CellCondition.Death;
			}
			else
			{
				cell = CellCondition.Live;
			}
		}

		public object Clone()
		{
			Cell clon = new Cell();
			clon.cell = this.cell;
			return clon; 
		}

		public CellCondition GetCell() { return cell; }
	}
}