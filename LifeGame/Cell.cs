using System;

namespace LifeGame
{
	public sealed class Cell : ICloneable
	{
		private CellCondition cell;

		public Cell()
		{
			cell = CellCondition.Death;
		}

		public CellCondition Condition
		{
			get { return cell; }
		}

		public void ChangeState()
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
			Cell clone = new Cell();
			clone.cell = cell;
			return clone;
		}
	}
}