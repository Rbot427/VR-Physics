using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foo : DisplayContainer {
	private int _test;
	public int test {
		get { return _test; }
		set { _test = value; }
	}

	private string _str;
	public string str {
		get { return _str; }
		set { _str = value; }
	}

	private double _doub;
	public double doub {
		get { return _doub; }
		set { _doub = value; }
	}

	//public Rigidbody r;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
