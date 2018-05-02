using LifeGame;
using System;

namespace LifeGame
{
	public interface IMoves
	{
		void Move();
		ConsoleKey GetArrow();
	}
}
