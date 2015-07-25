using UnityEngine;
using System.Collections;

public class King : Character {

	public King(WeaponBehavior weapon)
	{
		setWeapon(weapon);
	}

	#region implemented abstract members of Character

	public override void Fight ()
	{
		Debug.Log(gameObject.name+" Fight with "+DoFightUsingWeapon());
	}

	#endregion

	void Start()
	{
		setWeapon(new SwordBehavior());
	}


	void Update()
	{
		if(Input.GetMouseButtonDown(0))
			Fight();
			
		if(Input.GetMouseButtonDown(1))
			setWeapon(new AxeBehavior());
	}
	
	
	
}
