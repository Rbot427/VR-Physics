using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class LinearForce : FunctionObject {
	//@TODO: add widget showing direction of force at start

	public Vector3 direction;
	public Rigidbody rb;


	//delegates work!
	public delegate float Function();
	public Function getForce;

	//this is here because custom inspector can't handle delegates yet
	private float GetForce(){
		float m = 0;
		float b = 1;
		float x = gameObject.transform.position.y;

		return m * x + b;
	}

	// Use this for initialization
	protected override void Start () {
		base.Start ();
		direction.Normalize ();
		rb = gameObject.GetComponent<Rigidbody> ();

		//will be removed once custom inspector is working
		getForce=GetForce;
	}

	// Update is called once per frame
	protected override void Update () {
		base.Update ();
	}

	protected override void OnDrawGizmos(){
		Vector3 pos = gameObject.transform.position;
		direction.Normalize ();
		Vector3 dir = direction*getForce ();
		Gizmos.DrawLine (pos, pos+dir);
	}

	protected void FixedUpdate(){
		float scale = getForce ();
		direction.Normalize ();
		rb.AddForce (direction*scale);
	}
}
