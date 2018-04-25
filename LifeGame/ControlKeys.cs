namespace LifeGame
{
	public class ControlKeys
	{
		private Universe universe;
		private CursorX cursor;

		public ControlKeys(Universe universe, CursorX cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
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
			if (universe[cursor.GetY(), cursor.GetX()].Get() == ' ')
			{
				universe[cursor.GetY(), cursor.GetX()].Set('0');
			}
			else
			{
				universe[cursor.GetY(), cursor.GetX()].Set(' ');
			}
		}
	}
}