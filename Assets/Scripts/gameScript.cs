using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	static int score;
	static int health;
	static float timer; //timer decreases over time
	// Use this for initialization
	void Start () {
		score = 0;
		health = 3;
		timer = 20;
	}
	
	// Update is called once per frame
	void Update () {
		CountDown();

	}


	public void updateScore()
	{
		score++;
		timer+=2;
	}

	public void ateHealthy()
	{
		health--;
	}

	//create the gui for the game
	void OnGUI() {
		GUIStyle style = new GUIStyle();
		style.fontSize = 10;
		GUI.Label(new Rect(0,0,100,20), "Score:" + score + "\r\n" + "Health:" + health + "\r\n" +  "Timer:" + timer, style);	
	}

	void PauseGame()
	{
		if (Time.timeScale == 1) 
		{
			Time.timeScale = 0;
		} 
		else 
		{
			Time.timeScale = 1;
		}
	}
	
	void CountDown()
	{
		timer -= Time.deltaTime;
	}
}
