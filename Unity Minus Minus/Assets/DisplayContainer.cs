using UnityEngine;
using System.Collections;
using System.Reflection;

public abstract class DisplayContainer : MonoBehaviour {
	public PropertyInfo[] getProperties() {
		return GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
	}


	//for consistency's sake...no idea what I'm doing, tbh
	virtual protected void Start(){
		
	}

	virtual protected void Update(){
		
	}
}