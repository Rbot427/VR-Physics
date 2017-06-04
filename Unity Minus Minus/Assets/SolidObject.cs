using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SolidObject : DisplayContainer {

	public Rigidbody rigidBody;
	public MeshFilter meshFilter;
	public MeshRenderer meshRenderer;
	//While I'd like to add a generic collider, I don't know how to make one

	// Use this for initialization
	virtual new protected void Start () {
		base.Start ();
		gameObject.AddComponent<Rigidbody>();
		rigidBody = gameObject.GetComponent<Rigidbody> ();
		rigidBody.useGravity = false;

		gameObject.AddComponent<MeshFilter> ();
		meshFilter = gameObject.GetComponent<MeshFilter> ();
		GameObject temp_cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		meshFilter.mesh = (temp_cube).GetComponent<MeshFilter>().sharedMesh;
		GameObject.DestroyImmediate (temp_cube);

		gameObject.AddComponent<MeshRenderer> ();
		meshRenderer = gameObject.GetComponent<MeshRenderer> ();
	}

	// Update is called once per frame
	virtual new protected void Update () {
		base.Update ();
	}
}
