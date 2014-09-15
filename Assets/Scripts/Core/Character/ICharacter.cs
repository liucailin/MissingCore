using Core.Obj;
using UnityEngine;

namespace Core.Obj
{
	public interface IAttacker
	{
		void Attack();
	}

	public interface IDefender
	{
		void Defend(int beAttacked);
	}
}

