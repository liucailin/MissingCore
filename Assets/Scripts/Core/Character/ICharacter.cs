using Core.Obj;
using UnityEngine;

namespace Core.Obj
{
	public interface IMover
	{
		void Move(Vector3 translation, Space relativeTo = Space.World);
		void MoveTo(CxObj cxObj);
	}

	public interface IAttacker
	{
		void Attack();
	}

	public interface IDefender
	{
		void Defend(int beAttacked);
	}
}

