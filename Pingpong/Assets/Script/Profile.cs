using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profile : MonoBehaviour {

	public GameObject []panel;

	int panel_index;

	// Use this for initialization
	void Start () {
		panel_index = 0;
		panel [panel_index].SetActive (true);
		
	}
	

	public void Update_panel (int i) {
		
		panel [panel_index].SetActive (false);
		panel_index = i;
		panel [panel_index].SetActive (true);
		
	}
}
