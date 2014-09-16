using Core.Obj;
using UnityEngine;
using Core.Obj.Manager;

namespace Core.Obj
{
	public class CxCharacterVO : CxObjVO
	{


	}

	public class CxCharacter : CxObj, IAttacker, IDefender, ICharacter
	{
		public override void Create (CxObjVO cxObjVO)
		{
			base.Create (cxObjVO);
		}

		public void Die ()
		{
			CxObjPoolManager.Instance.ReleaseCxObj (this);
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

