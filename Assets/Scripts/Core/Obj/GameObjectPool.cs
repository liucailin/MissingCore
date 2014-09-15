using UnityEngine;
using Core.Obj;

namespace Core.Obj
{
	public class GameObjectPool : ObjPool<Object>
	{
		public GameObjectPool(Object pooledGo, int capacity) : base (pooledGo, capacity) {}


		protected override Object Pooled {
			get {
				Object pooledObj = Object.Instantiate(pooled);
				(pooledObj as GameObject).SetActive(false);
				return pooledObj;
			}
		}

		public override Object PopObj ()
		{
			Object popObj = base.PopObj ();
			(popObj as GameObject).SetActive(true);
			return popObj;
		}

		public override void PushObj (Object pushed)
		{
			base.PushObj (pushed);
		}
	}

	public class CxObjPool : ObjPool<CxObj>
	{
		public CxObjPool(CxObj pooledCxObj, int capacity) : base (pooledCxObj, capacity) {}

		protected override CxObj Pooled {
			get {
				CxObj cxObj = CxObj.Clone (pooled);
				cxObj.objView.ViewGameObject.SetActive (false);
				return cxObj;
			}
		}

		public override CxObj PopObj ()
		{
			CxObj cxObj =  base.PopObj ();
			cxObj.objView.ViewGameObject.SetActive (true);
			return cxObj;
		}
	}
}


