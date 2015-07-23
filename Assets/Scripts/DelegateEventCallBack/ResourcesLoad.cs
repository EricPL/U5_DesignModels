using UnityEngine;
using System.Collections;

public class ResourcesLoad : MonoBehaviour {

	private GameObject loadObject;

	void Awake()
	{
		loadObject=GameObject.Instantiate(Resources.Load("SingletonCube",typeof(GameObject))) as GameObject;
		
		loadObject.transform.position=Vector3.one;
	}

	
}
