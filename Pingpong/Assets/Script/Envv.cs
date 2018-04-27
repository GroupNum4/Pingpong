using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envv : MonoBehaviour {

	public GameObject []walls;
	public Material[] mat;
	int mat_index;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
public 	void Update_wall (int i) {
	//	print ("called");

		mat_index = i;

		for (int j = 0; j < walls.Length; j++)
			walls [j].GetComponent<Renderer> ().material = mat [mat_index];

		
	}
}
