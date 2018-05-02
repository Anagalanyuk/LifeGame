using LifeGame;
using System;

namespace LifeGame
{
	public interface IMoves
	{
		void Move();
		ConsoleKey GetArrow();
	}

	public class StepRight:IMoves
	{
		private Universe universe;
		private CursorX cursor;
		private ConsoleKey arrow;

		public StepRight(Universe universe, CursorX cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.RightArrow;
		}

		public void Move()
		{
			if (cursor.GetX() < universe.GetColumns() - 1)
			{
				cursor.SetX(cursor.GetX() + 1);
			}
		}

		public ConsoleKey GetArrow()
		{
			return arrow;
		}
	}

	public class StepLeft:IMoves
	{
		private Universe universe;
		private CursorX cursor;
		ConsoleKey arrow;

		public StepLeft(Universe universe, CursorX cursor)
		{
			this.universe = universe;
			this.cursor = cursor;
			arrow = ConsoleKey.LeftArrow;
		}

		public void Move()
		{
			if (cursor.GetX()  > 0)
			{
				cursor.SetX(cursor.GetX() - 1);
			}
		}

		public ConsoleKey GetArrow()
		{
			return arrow;
		}
	}
} 

public class StepUP:IMoves
{
	private Universe universe;
	private CursorX cursor;
	private ConsoleKey arrow;

	public StepUP(Universe universe, CursorX cursor)
	{
		this.universe = universe;
		this.cursor = cursor;
		arrow = ConsoleKey.UpArrow;
	}

	public void Move()
	{
		if (cursor.GetY() > 0)
		{
			cursor.SetY(cursor.GetY() - 1);
		}
	}

	public ConsoleKey GetArrow()
	{
		return arrow;
	}
}

public class StepDown : IMoves
{
	private Universe universe;
	private CursorX cursor;
	public ConsoleKey arrow;

	public StepDown(Universe universe, CursorX cursor)
	{
		this.universe = universe;
		this.cursor = cursor;
		arrow = ConsoleKey.DownArrow;
	}

	public void Move()
	{
		if (cursor.GetY() < universe.GetRows() - 1)
		{
			cursor.SetY(cursor.GetY() + 1);
		}
	}

	public ConsoleKey GetArrow()
	{
		return arrow;
	}
}

public class KeyEnter:IMoves
{
	private Universe universe;
	private CursorX cursor;
	private ConsoleKey arrow;

	public KeyEnter(Universe universe,CursorX cursor)
	{
		this.universe = universe;
		this.cursor = cursor;
		arrow = ConsoleKey.Enter;
	}

	public void Move()
	{
		universe[cursor.GetY(), cursor.GetX()].ChancheState();
	}

	public ConsoleKey GetArrow()
	{
		return arrow;
	}
}