using Core.Obj;
using UnityEngine;

namespace Core.Obj
{
	public class CxCharacter : CxObj, IAttacker, IDefender
	{
		public override void Create (CxObjVO cxObjVO)
		{
			base.Create (cxObjVO);
		}

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



	public interface IUpdateable
	{
		void Update();
	}

}

