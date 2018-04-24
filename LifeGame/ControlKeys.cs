namespace LifeGame
{
	public class ControlKeys
	{
		private Universe universe;
		private int rows = 0;
		private int columns = 0;

		public ControlKeys(Universe universe)
		{
			this.universe = universe;
		}

		public void StepsRight()
		{
			if (rows != universe.GetRows() - 1)
			{
				Cell step = universe[rows + 1, columns];
				universe[rows + 1, columns] = universe[rows, columns];
				universe[rows, columns] = step;
				rows++;
			}
		}

		public void StepLeft()
		{
			if (rows != 0)
			{
				Cell step = universe[rows - 1, columns];
				universe[rows - 1, columns] = universe[rows, columns];
				universe[rows, columns] = step;
				--rows;
			}
		}

		public void StepDown()
		{
			if (columns != universe.GetColumns() - 1)
			{
				Cell step = universe[rows, columns + 1];
				universe[rows, columns + 1] = universe[rows, columns];
				universe[rows, columns] = step;
				++columns;
			}
		}

		public void StepUp()
		{
			if (columns != 0)
			{
				Cell step = universe[rows, columns - 1];
				universe[rows, columns - 1] = universe[rows, columns];
				universe[rows, columns] = step;
				--columns;
			}
		}

		public void KeySpace()
		{
			if (rows != universe.GetRows() - 1)
			{
				Cell life = new Cell('0');
				universe[rows + 1, columns] = universe[rows, columns];
				universe[rows, columns] = life;
				++rows;
			}
			else
			{
				Cell life = new Cell('0');
				universe[rows - 1, columns] = universe[rows, columns];
				universe[rows, columns] = life;
				--rows;
			}
		}
	}
}