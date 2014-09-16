using UnityEngine;
using System.Collections;
using Core.Obj.Manager;
using Core.Obj;
using System;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {


		//Profiler.BeginSample("MyPieceOfCode");
		
		PrintMemoryUsage ();
		CxObjPoolManager.Instance.RegPool (CxObjFactory.Instance.GetSimpleCx (), 500);
		PrintMemoryUsage ();
		//Profiler.EndSample();
		
		InvokeRepeating("AddCube", 0, 0.05f);
		//InvokeRepeating("ReduceCube", 0, 0.8f);



	
	}


	void PrintMemoryUsage (int index = 0)
	{
		print (index + " usedHeapSize: " + Profiler.usedHeapSize);
		print (index + " GetMonoHeapSize: " + Profiler.GetMonoHeapSize ());
		print (index + " GetMonoUsedSize: " + Profiler.GetMonoUsedSize ());
		print (index + " GetTotalAllocatedMemory: " + Profiler.GetTotalAllocatedMemory ());
		print (index + " GetTotalReservedMemory: " + Profiler.GetTotalReservedMemory ());
		print (index + " GetTotalUnusedReservedMemory: " + Profiler.GetTotalUnusedReservedMemory ());

		uint curuse = Profiler.GetTotalAllocatedMemory ();
		print (index + " " +( curuse - lastuse));
		lastuse = curuse;


	}

	void AddCube()
	{
		CxObj cxObj = CxObjPoolManager.Instance.GetCxObj<CxObj> ();
		cxObj.objView.ViewTransform.position = new Vector3 (x, 0, 0);
		x ++;		
		PrintMemoryUsage (x);
	}

	void ReduceCube ()
	{


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int x;
	uint lastuse;
}
