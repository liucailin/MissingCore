using Core.Obj;
using UnityEngine;

namespace Core.Obj
{
	public class CxCharacter : CxObj, IAttacker, IDefender
	{
		public void Attack ()
		{
			throw new System.NotImplementedException ();
		}

		public void Defend (int beAttacked)
		{
			throw new System.NotImplementedException ();
		}

		IMover CharacterMover
		{
			get; set;
		}
	}

	public class Mover : IMover
	{
		public void Move (Vector3 translation, Space relativeTo = Space.World)
		{
			trans.Translate(translation, relativeTo);
		}

		public void MoveTo (CxObj cxObj)
		{
			Move (cxObj.objView.ViewTransform.position);
		}


		Transform trans;
	}

	public interface IUpdateable
	{
		void Update();
	}

}

