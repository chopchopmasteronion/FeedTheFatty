using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	static int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void updateScore()
	{
		score++;
	}

	//create the gui for the game
	void OnGUI() {
		GUIStyle style = new GUIStyle();
		style.fontSize = 10;
		GUI.Label(new Rect(0,0,100,20), "Score:" + score, style );	
	}
}
