using System.Collections;
using UnityEngine;
/// <summary>
/// All Heros' Base Class 
/// </summary>
public abstract class Character : MonoBehaviour{

	WeaponBehavior weaponBehavior;

	public abstract void Fight();

	public void setWeapon(WeaponBehavior wp)
	{
		this.weaponBehavior=wp;
	}
	
	public string DoFightUsingWeapon()
	{
	 	return weaponBehavior.useWeapon();
	}

}
