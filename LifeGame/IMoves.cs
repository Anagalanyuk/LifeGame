using System;

namespace LifeGame
{
	public interface IMoves
	{
		void Move();

		ConsoleKey Arrow { get; }
	}
}
