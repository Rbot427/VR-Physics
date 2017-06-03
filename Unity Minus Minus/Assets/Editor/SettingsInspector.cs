using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;

[CustomEditor(typeof(DisplayContainer))]
public class SettingsInspector : Editor {
	
	public override void OnInspectorGUI() {
		DisplayContainer tar = (DisplayContainer)target;
		constructDisplay(tar);
		//DrawDefaultInspector();
	}

	private void constructDisplay(DisplayContainer tar) {
		PropertyInfo[] p = tar.getProperties();
		//Debug.Log(p.Length.ToString());
		foreach(PropertyInfo i in p) {
			System.Type t = i.PropertyType;
			if(t.IsClass) {
				if(t.GetInterface("Displayable") != null) {//So if one of the properties is another object
					Debug.Log("Awww, crap... I haven't implemented that yet...");
				}
			}
			MethodInfo get = i.GetGetMethod();
			MethodInfo setter = i.GetSetMethod();
			object[] param = new object[1];

			if(t.Equals(typeof(System.Int32))) {
				param[0] = EditorGUILayout.IntField(i.Name, (int)get.Invoke(tar, null));
			} else if(t.Equals(typeof(System.String))) {
				param[0] = EditorGUILayout.TextField(i.Name, (string)get.Invoke(tar, null));
			} else if(t.Equals(typeof(System.Double))) {
				param[0] = EditorGUILayout.DoubleField(i.Name, (double)get.Invoke(tar, null));
			}
			if (param [0] != null) {
				GUILayout.BeginHorizontal ();
				setter.Invoke (tar, param);
				GUILayout.EndHorizontal ();
			}
		}
	}
}

[CustomEditor(typeof(Foo))]
public class FooInspector : SettingsInspector {
}

[CustomEditor(typeof(Bar))]
public class BarInspector : SettingsInspector {
}