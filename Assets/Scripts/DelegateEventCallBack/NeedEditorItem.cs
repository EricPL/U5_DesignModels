using UnityEngine;
using System.Collections;

public class NeedEditorItem : MonoBehaviour {

	public GameObject weapon_1;
	public GameObject weapon_2;
	public GameObject weapon_3;
	
	public GameObject defind_1;
	public GameObject defind_2;
	public GameObject defind_3;

	public GameObject skill_1;
	public GameObject skill_2;
	public GameObject skill_3;
	
	public int number;
	public float floatNumber;
	
	public Vector3 position;
	
	[SerializeField]
	private int selectInt;
	
	public bool showWeaponDetails;
	
	public enum EnumValue
	{
		enum_1,
		enum_2,
		enum_3
	}
	
	public EnumValue enumVale;

}
