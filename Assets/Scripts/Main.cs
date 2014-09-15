using UnityEngine;
using System.Collections;
using Core.Manager;
using Core.Obj;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {



		CxObjPoolManager.Instance.RegPool (CxObjFactory.Instance.GetSimpleCx (), 30);

		InvokeRepeating("AddCube", 0, 0.5f);
		InvokeRepeating("ReduceCube", 0, 0.8f);

	
	}

	void AddCube()
	{
		CxObj cxObj = CxObjPoolManager.Instance.GetObj<CxObj> ();
		cxObj.objView.ViewTransform.position = new Vector3 (x, 0, 0);
		x ++;		
	}

	void ReduceCube ()
	{
		CxObjPool cxPool = CxObjPoolManager.Instance.GetObjPool ();
		cxPool.PushObj (GameObject.Find ("cube"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	float x;
}
