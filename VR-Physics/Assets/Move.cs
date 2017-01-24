using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float camera_speed;
	// Use this for initialization
	void Start () {
	
	}

	private Vector3 Scale(Vector3 v, float scale) { //why does unity not support this?
		v.Set(v.x*scale, v.y*scale, v.z*scale);
		return v;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w"))
			transform.position = transform.position + Scale (transform.forward, camera_speed);
		if (Input.GetKey("a"))
			transform.position = transform.position - Scale (transform.right, camera_speed);
		if (Input.GetKey("d"))
			transform.position = transform.position + Scale (transform.right, camera_speed);
		if (Input.GetKey("s"))
			transform.position = transform.position - Scale (transform.forward, camera_speed);
	}
}
