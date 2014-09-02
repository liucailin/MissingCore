using System;
using Core.Obj;
using Core.Util;

namespace Core.Manager
{
	public class ObjPoolManager : Singleton<ObjPoolManager>
	{

		public void RegPool(Type poolType, object pooledObj)
		{
			poolCon.AddObj(poolType, new ObjPool<object>(pooledObj, 100));
		}

		public ObjPool<object> GetPool(Type poolType)
		{
			return null;
		}



		ObjContainer<Type, ObjPool<object>> poolCon = new ObjContainer<Type, ObjPool<object>>();
	}
}

