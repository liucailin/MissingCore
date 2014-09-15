using System;
using Core.Obj;
using Core.Util;
using UnityEngine;

namespace Core.Manager
{
	public class CxObjPoolManager : Singleton<CxObjPoolManager>
	{
		public void RegPool<T> (T pooledObj, int poolCount)  where T : CxObj
		{
			this.poolType = typeof (T);
			poolCon.AddObj(poolType, new CxObjPool (pooledObj, poolCount));
		}
		
		public CxObjPool GetObjPool ()
		{
			return poolCon.GetObj (poolType);
		}

		public CxObj GetCxObj ()
		{
			return GetObjPool ().PopObj ();
		}

		public T GetObj<T> () where T : CxObj
		{
			return GetCxObj () as T;
		}
		
		Type poolType;
		ObjContainer<Type, CxObjPool> poolCon = new ObjContainer<Type, CxObjPool>();
	}
}

