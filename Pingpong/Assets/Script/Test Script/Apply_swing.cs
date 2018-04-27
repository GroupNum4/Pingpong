using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apply_swing : MonoBehaviour {

	public Vector3 swing;
	public bool force_applied;

	// Use this for initialization
	void Start () {
		force_applied = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision obj)
	{

		if (obj.transform.tag == "Swing"  && !force_applied ) {

			force_applied = true;
			//print ("Force Applied");
			obj.gameObject.GetComponent<Rigidbody> ().AddForce (swing);
		}
	}
}
