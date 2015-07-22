using UnityEngine;
using System.Collections;

public class testSingleton : Singleton<testSingleton> {

	void Start()
	{
		Debug.Log("I am "+testSingleton.Instance.ToString());
	}
	

	
}
