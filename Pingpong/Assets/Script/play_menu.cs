using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_menu : MonoBehaviour {

	public GameObject pause_menu,game_over;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pause()
	{
		pause_menu.SetActive (true);
		game_over.SetActive (false);
	}

	public void over()
	{
		game_over.SetActive (true);
	}
	public void Resume()
	{
		pause_menu.SetActive (false);
		game_over.SetActive (false);
	}

	public void Menu()
	{
		SceneManager.LoadSceneAsync ("menu");
	}
}
