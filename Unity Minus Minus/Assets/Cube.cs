using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : SolidObject {
	public BoxCollider boxCollider;

	// Use this for initialization
	override protected void Start () {
		base.Start ();

		gameObject.AddComponent<BoxCollider> ();
		boxCollider = gameObject.GetComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	override protected void Update () {
		base.Update ();
	}
}
