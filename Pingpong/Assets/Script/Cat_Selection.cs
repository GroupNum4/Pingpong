using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat_Selection : MonoBehaviour {

	public GameObject []Panels,racket_stats,ball_stats,table_stats;

	public Image rackets,balls,table;
	public Sprite []racket_s,balls_s,table_s;

	int panel_index,racket_index,ball_index,table_index;

	// Use this for initialization
	void Start () {
		panel_index = racket_index=ball_index=table_index=0;
		Panels [panel_index].SetActive (true);
		racket_stats [racket_index].SetActive (true);
		ball_stats [ball_index].SetActive (true);
		table_stats [table_index].SetActive (true);
		
	}
	

public void Change_Panel(int i) {
		Panels [panel_index].SetActive (false);
		panel_index = i;
		Panels [panel_index].SetActive (true);
		
	}

	public void change_racket(int i)
	{
		racket_stats [racket_index].SetActive (false);
		
		if (i==1) // means next racket
		{ 
			racket_index += 1;
			racket_index %= racket_s.Length;
		}
		else
		{
			racket_index -= 1;
			if(racket_index < 0 )
				racket_index = racket_s.Length-1;
		}

		rackets.sprite = racket_s [racket_index];
		racket_stats [racket_index].SetActive (true);
	}
	public void change_ball(int i)
	{
		ball_stats [ball_index].SetActive (false);
		if (i==1) // means next ball
		{ 
			ball_index += 1;
			ball_index %= balls_s.Length;
		}
		else
		{
			ball_index -= 1;
			if(ball_index < 0 )
				ball_index = balls_s.Length-1;
		}

		balls.sprite = balls_s [ball_index];
		ball_stats [ball_index].SetActive (true);
	}
	public void change_table(int i)
	{
		table_stats [table_index].SetActive (false);
		if (i==1) // means next table
		{ 
			table_index += 1;
			table_index %= table_s.Length;
		}
		else
		{
			table_index -= 1;
			if(table_index < 0 )
				table_index = table_s.Length-1;
		}

		table.sprite = table_s [table_index];
		table_stats [table_index].SetActive (true);
	}
}
