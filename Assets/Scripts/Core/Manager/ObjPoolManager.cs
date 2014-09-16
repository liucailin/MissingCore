using System;
using Core.Obj;
using Core.Util;
using UnityEngine;

namespace Core.Obj.Manager
{
	public class CxObjPoolManager : Singleton<CxObjPoolManager>
	{
		public void InitPool ()
		{

		}

		public void RegPool<T> (T pooledObj, int poolCount) where T : CxObj
		{
			poolCon.AddObj(typeof(T), new CxObjPool (pooledObj, poolCount));
		}
		
		public CxObjPool GetPool<T> () where T : CxObj
		{
			return poolCon.GetObj (typeof (T));
		}

		public T GetCxObj<T> () where T : CxObj
		{
			return GetCxObj (typeof (T)) as T;
		}

		public CxObj GetCxObj (Type cxType)
		{
			return poolCon.GetObj (cxType).PopObj ();
		}

		public CxObj GetCxObj (string cxObjType)
		{
			Type t = Type.GetType ("Core.Obj" + cxObjType);
			return GetCxObj (t);
		}

		public void ReleaseCxObj<T> (T cxObj) where T : CxObj
		{
			GetPool<T> ().PushObj (cxObj);
		}
		
		ObjContainer<Type, CxObjPool> poolCon = new ObjContainer<Type, CxObjPool>();
	}
}

