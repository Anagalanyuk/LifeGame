namespace LifeGame
{
	public class ControlKeys
	{
		private Universe universe;
		private CursorX cursor;
	//	private int rows = 0;
		//private int columns = 0;

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
			if(cursor.GetX() < universe.GetRows() - 1)
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
			if( cursor.GetY() < universe.GetColumns() - 1)
			{
				cursor.SetY(cursor.GetY() + 1);
			}
		}

		public void KeyEnter()
		{
			if (universe[cursor.GetX(), cursor.GetY()].Get() == ' ')
			{
				universe[cursor.GetX(), cursor.GetY()].Set('0');
			}
			else
			{
				universe[cursor.GetX(), cursor.GetY()].Set(' ');
			}
		}
	}
}