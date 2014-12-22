using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {
	static int score;
	static int health;
	static float timer; //timer decreases over time
	public Camera main;
	public int difficulty; //0-10
	int eatenCount;
	// Use this for initialization
	void Start () {
		score = 200;
		health = 3;
		timer = 20;
		setCamera(1);
		Time.timeScale = 1;
		eatenCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		CountDown();
		if(0 == GameOver ())
			{
				Application.LoadLevel("GameOver");
			}
		setDifficulty();
	}


	public void updateScore(int weight)
	{
		score+= weight;
		timer+=2;
		eatenCount++;
	}

	public void ateHealthy()
	{
		health--;
	}

	//create the gui for the game
	void OnGUI() {
		GUIStyle style = new GUIStyle();
		style.fontSize = 10;
		GUI.Label(new Rect(0,0,100,20), "Weight:" + score + " LBS" + "\r\n" + "Health:" + health + "\r\n" +  "Timer:" + timer, style);	
	}

	void PauseGame()
	{
		if (Time.timeScale == 1) 
		{
			Time.timeScale = 0;
			setCamera(2);
		} 
		else 
		{
			Time.timeScale = 1;
			setCamera(1);
		}
	}

	void RestartGame()
	{
		Application.LoadLevel("FattyGame");
	}
	
	void CountDown()
	{
		timer -= Time.deltaTime;
	}

	int GameOver()
	{
		int status = 1; //game running
		if(timer <= 0 || health <= 0)
		{
			status = 0;
		}
		return status;
	}

	void setCamera(int location)
	{
		if(location == 1) //set to game position
		{
			main.camera.transform.position = (new Vector3(0,0,-10));	
		}
		if (location == 2) //pause position
		{
			main.camera.transform.position = (new Vector3(-29,0,-1));
		}
	}

	void setDifficulty()
	{
		if(difficulty < 5)
		{
			if(eatenCount== 10)
			{
				difficulty++;
				eatenCount = 0;
			}
		}
	}
	
	public int getDifficulty()
	{
		return difficulty;
	}	
}
