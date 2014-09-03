using System;
using Core.Obj;
using Core.Util;
using UnityEngine;

namespace Core.Manager
{
	public class ObjPoolManager : Singleton<ObjPoolManager>
	{

		public void RegPool(Type poolType, object pooledObj)
		{
			poolCon.AddObj(poolType, new ObjPool<object>(pooledObj, 10));
		}

		public ObjPool<object> GetPool(Type poolType)
		{
			return null;
		}



		ObjContainer<Type, ObjPool<object>> poolCon = new ObjContainer<Type, ObjPool<object>>();
	}

	public class GameObjectPoolManager : Singleton<GameObjectPoolManager>
	{
		public void RegPool(Type poolType, UnityEngine.Object pooledObj)
		{
			poolCon.AddObj(poolType, new GameObjectPool(pooledObj, 10));
		}

		public GameObjectPool GetGameObjectPool(Type poolType)
		{
			return poolCon.GetObj(poolType);
		}

		ObjContainer<Type, GameObjectPool> poolCon = new ObjContainer<Type, GameObjectPool>();
	}
}

