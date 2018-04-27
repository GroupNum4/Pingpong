using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public Vector3 rot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.up, 10*Time.deltaTime);
		//transform.rotation = Quaternion.Euler (rot.x*Time.deltaTime,rot.y*Time.deltaTime,rot.z*Time.deltaTime);
		//transform.eulerAngles (rot.x*Time.deltaTime,rot.y*Time.deltaTime,rot.z*Time.deltaTime);
	}
}
