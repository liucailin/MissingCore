using UnityEngine;
using Core.Obj;

namespace Core.Obj
{
	public class GameObjectPool : ObjPool<GameObject>
	{
		public GameObjectPool(GameObject pooledGo, int capacity) : base (pooledGo, capacity) {}


		protected override void AddPooledObj (GameObject pooled)
		{
			GameObject go = GameObject.Instantiate(pooled) as GameObject;
			go.SetActive(false);
			base.AddPooledObj (pooled);
		}

		public override GameObject PopObj ()
		{
			GameObject popObj = base.PopObj ();
			popObj.SetActive(true);
			return popObj;
		}

		public override void PushObj (GameObject pushed)
		{
			base.PushObj (pushed);
		}
	}
}


