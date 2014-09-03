using UnityEngine;
using System.Collections;
using Core.Manager;
using Core.Obj;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
		GameObjectPoolManager.Instance.RegPool(typeof(GameObject), go);


		InvokeRepeating("AddCube", 0, 0.5f);

	
	}

	void AddCube()
	{
		GameObject go = GameObjectPoolManager.Instance.GetGameObjectPool(typeof(GameObject)).PopObj() as GameObject;
		go.transform.position = new Vector3(x, 0, 0);
		x++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	float x;
}
