using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Get_Modes : MonoBehaviour {

	public GameObject[] Panels;
	string playerpref_name = "Mode";

	// Use this for initialization
	void Start () {
		Panels [PlayerPrefs.GetInt ("playerpref_name")].SetActive (true);
	}
}
