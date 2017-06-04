using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class LinearForce : FunctionObject {
	//@TODO: add widget showing direction of force at start

	public Vector3 direction;

	public int m;
	public int b;
	public System.Object x_object;//object to which getter is applied
	public MethodInfo x_getter;//Default inspector can't handle this, I don't think. We'll need to add it to custom inspector

	public Rigidbody rb;

	// Use this for initialization
	protected override void Start () {
		base.Start ();
		direction=new Vector3(0,1,0);

		m = 0;
		b = 1;
		rb = gameObject.GetComponent<Rigidbody> ();

		//while custom inspector can't handle adding a getter
		x_object=gameObject.transform.position;
		x_getter=gameObject.transform.position.GetType().GetProperty("Item").GetGetMethod();
		Debug.Log (x_getter.Invoke ((System.Object)x_object, null));
	}

	// Update is called once per frame
	protected override void Update () {
		base.Update ();
	}

	protected void FixedUpdate(){
		int x = (int)x_getter.Invoke (x_object, null);
		int scale = m * x + b;
		direction.Normalize ();
		rb.AddForce (direction*scale);
	}
}
