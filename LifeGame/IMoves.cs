using System;

namespace LifeGame
{
	public interface IMoves
	{
		ConsoleKey Arrow { get; }

		void Move();
	}
}