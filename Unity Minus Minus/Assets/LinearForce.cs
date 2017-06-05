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
		direction=new Vector3(0,1,0);
		rb = gameObject.GetComponent<Rigidbody> ();

		//will be removed once custom inspector is working
		getForce=GetForce;
	}

	// Update is called once per frame
	protected override void Update () {
		base.Update ();
	}

	protected void FixedUpdate(){
		float scale = getForce ();
		direction.Normalize ();
		rb.AddForce (direction*scale);
	}
}
