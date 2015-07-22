using System;
using System.Collections;
using UnityEngine;

public class Singleton<T> : MonoBehaviour 
	where T : Component
{

	private static T _instance;
	public static T Instance
	{
		get {
		
			_instance=FindObjectOfType(typeof(T)) as T;
		
			if(_instance==null)
			{
				GameObject obj = new GameObject();
				obj.hideFlags=HideFlags.HideAndDontSave;
				_instance = obj.AddComponent(typeof(T)) as T;	
			}
			
			return _instance;
		}
	}
}
