using UnityEngine;
using UnityEditor;
using System.Collections;

public class NeedEditorEditor : EditorWindow {

	[MenuItem("EditorDemo/createWindow")]
	
	static void CreateWindow()
	{
		EditorWindow.GetWindow(typeof(NeedEditorEditor),false,"NeedEditorItem",true);
	}
	
	bool toggle;
	Color color;
	AnimationCurve animationCurve;
	float floatValue=0f;
	bool foldOut;
	enum EnumList
	{
		enum0,
		enum1,
		enum2
	}
	EnumList enumValue=EnumList.enum0;
	
	
	void Start()
	{
		animationCurve=new AnimationCurve();
	}
	
	void OnGUI()
	{
		toggle=EditorGUILayout.Toggle("Toggle",toggle);
		EditorGUILayout.LabelField("This is a LabelFiled");
		color=EditorGUILayout.ColorField("Color",color);
		animationCurve=EditorGUILayout.CurveField("AnimationCurve",animationCurve);
		floatValue=EditorGUILayout.FloatField("FloatField",floatValue);
		enumValue=(EnumList)EditorGUILayout.EnumPopup("EnumPopup",enumValue);
		
	}
	
}
