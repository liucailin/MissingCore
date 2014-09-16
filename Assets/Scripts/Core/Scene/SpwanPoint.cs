using System;
using System.Collections.Generic;
using UnityEngine;
using Core.Obj;
using Core.Obj.Manager;

public class SpwanPoint : MonoBehaviour
{
	public int spwanCount = 5;
	public string spwanType;

	void Awake ()
	{
		cxObjList = new List<CxObj> (spwanCount);		
	}

	void OnEnable ()
	{
		Spwan ();
	}

	public void Spwan ()
	{
		for ( int i = 0; i < spwanCount; i ++)
		{
			CxObj born = CxObjPoolManager.Instance.GetCxObj (spwanType);
			cxObjList.Add (born);
		}
	}

	void OnDisable ()
	{
		Gone ();
	}

	public void Gone ()
	{
		for ( int i = 0; i < spwanCount; i ++)
		{
			CxObj gone = cxObjList[i];
			if (!gone.IsPooled) CxObjPoolManager.Instance.ReleaseCxObj (gone);
		}
	}

	List<CxObj> cxObjList;
}


