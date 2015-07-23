using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor(typeof(NeedEditorItem))]
public class NeedEditorTest : Editor {

	bool isWeaponShowed=false;

	public override void OnInspectorGUI ()
	{
		serializedObject.Update();
	
		NeedEditorItem item=(NeedEditorItem)target;
		
		EditorGUILayout.BeginHorizontal();
		item.weapon_1=EditorGUILayout.ObjectField("Weapon_1",item.weapon_1,typeof(GameObject),true) as GameObject;
		EditorGUILayout.EndHorizontal();
		
		isWeaponShowed=EditorGUILayout.Foldout(isWeaponShowed,"test");
		
		if(isWeaponShowed){
			item.showWeaponDetails=EditorGUILayout.BeginToggleGroup("toggleGround",item.showWeaponDetails);
			item.weapon_2=EditorGUILayout.ObjectField("Weapon_2",item.weapon_2,typeof(GameObject),true) as GameObject;
			item.weapon_3=EditorGUILayout.ObjectField("Weapon_3",item.weapon_3,typeof(GameObject),true) as GameObject;
			EditorGUILayout.EndToggleGroup();
		}
		
		
		if(GUI.changed)
			EditorUtility.SetDirty(item);

		serializedObject.ApplyModifiedProperties();
	}



}
