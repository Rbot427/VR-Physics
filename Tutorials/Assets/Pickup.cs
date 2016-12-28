using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
	public DynamicObject target;
	public int strength = 5;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("r")) {
			//ToDo:  Make it a different way to pick stuff up
			target.pickUp ();
		} else
			target.putDown ();
		if (Input.GetKey ("j")) {
			//Debug.Log ("TRYING TO MOVE THIS FING THING");
			target.addForce(new Vector3(0.1f, 0, 0), ForceMode.VelocityChange);
		}
		this.transform.LookAt (target.transform);
		if (Input.GetKey (KeyCode.UpArrow))
			this.transform.position += this.transform.up;
		if (Input.GetKey (KeyCode.DownArrow))
			this.transform.position -= this.transform.up;
		if (Input.GetKey (KeyCode.LeftArrow))
			this.transform.position -= this.transform.right;
		if (Input.GetKey (KeyCode.RightArrow))
			this.transform.position += this.transform.right;
	}
}
