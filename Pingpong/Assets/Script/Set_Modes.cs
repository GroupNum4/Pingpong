using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Set_Modes : MonoBehaviour {

	public Text []modes_Text;

	string playerpref_name = "Mode";

	// Use this for initialization
	void Start () {

		for (int i = 0; i < modes_Text.Length; i++)
			modes_Text [i].color = new Color (255, 255, 255, 255);

		modes_Text [PlayerPrefs.GetInt("playerpref_name")].color = new Color (255, 255, 0, 255);
		
	}
	
	// Update is called once per frame
	public void update_Mode(int i) {

		modes_Text [PlayerPrefs.GetInt("playerpref_name")].color = new Color (255, 255, 255, 255);
		PlayerPrefs.SetInt ("playerpref_name", i);
		modes_Text [PlayerPrefs.GetInt("playerpref_name")].color = new Color (255, 255, 0, 255);
	}
}
