using System.Collections;
using Core.Obj;
using UnityEngine;

public class SceneMap : MonoBehaviour
{
	public Transform mapTrans;

	public Vector2 mapArea = new Vector2 (1000, 1000);
	public Vector2 sceneArea = new Vector2 (100, 100);
	public Vector2 sceneAreaBorder = new Vector2(50, 50);

	void RegArea ()
	{

	}

	ObjContainer<int, SceneArea> areaCon = new ObjContainer<int, SceneArea> ();
}


