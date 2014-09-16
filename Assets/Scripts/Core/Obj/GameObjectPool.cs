using UnityEngine;
using Core.Obj;

namespace Core.Obj
{
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


