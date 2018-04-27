using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Buy_panel : MonoBehaviour {
	public GameObject sure, not_cash;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	public void sure_func()
	{
		sure.SetActive (true);
	}

	public void not_cash_func()
	{
		not_cash.SetActive (true);
	}

	public void close ()
	{
		sure.SetActive (false);
		not_cash.SetActive (false);
	}
}
