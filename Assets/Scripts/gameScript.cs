using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	static int score;
	static int health;
	// Use this for initialization
	void Start () {
		score = 0;
		health = 3;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void updateScore()
	{
		score++;
	}

	public void ateHealthy()
	{
		health--;
	}

	//create the gui for the game
	void OnGUI() {
		GUIStyle style = new GUIStyle();
		style.fontSize = 10;
		GUI.Label(new Rect(0,0,100,20), "Score:" + score + "\r\n" + "Health:" + health, style);	
	}
}
