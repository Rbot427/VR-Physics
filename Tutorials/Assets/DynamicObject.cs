using UnityEngine;
using System.Collections;

public class DynamicObject : MonoBehaviour {
	// Use this for initialization
	private Rigidbody r;
	private bool isHeld;

	void Start () {
		if (this.GetComponent<Rigidbody>() == null)
			Debug.Log ("Must have rigidbody");
		else
			this.r = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pickUp() {
		this.r.useGravity = false;
		this.isHeld = true;
	}

	public void putDown() {
		this.r.useGravity = true;
		this.isHeld = false;
	}

	public void addForce(Vector3 s, ForceMode mode) {
		this.r.AddForce (s, mode);
	}
}
