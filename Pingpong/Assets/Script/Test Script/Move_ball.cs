using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_ball : MonoBehaviour {

	Rigidbody rb;
	public Vector3 speed;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();

		rb.AddForce (speed);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
