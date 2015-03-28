using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class gameScript : MonoBehaviour {
	static int score;
	static int health;
	static float timer; //timer decreases over time
	public Camera main;
	public int difficulty; //0-10
	private int diffScale;
	int eatenCount;
	public GameObject heart;
	public Sprite[] hearts;
	public Text clock;
	public Text scale;

	// Use this for initialization
	void Start () {
		score = 200;
		health = 1;
		timer = 20;
		setCamera(1);
		Time.timeScale = 1;
		eatenCount = 0;
		diffScale = Random.Range(1,5);
	}
	
	// Update is called once per frame
	void Update () {
		CountDown();
		if(0 == GameOver ())
			{
				persistence ps = new persistence();
				ps.saveScore(score);
				Application.LoadLevel("GameOver");
			}
		setDifficulty();
	}


	public void updateScore(int weight)
	{
		score+= weight;
		timer+=2;
		eatenCount++;
		fatty guy = (fatty)GameObject.Find("body").GetComponent(typeof (fatty));
		guy.grow();
	}

	public void ateHealthy()
	{
		health--;
		if (health > 0)
		{ 
		heart.GetComponent<SpriteRenderer>().sprite=hearts[health-1];
		}
	}

	//This was great, that's all I'm gonna say...
	void OnGUI() {
		int intTimer = (int)timer;
		scale.text = score.ToString();
		clock.text = intTimer.ToString(); 	
	}

	public void PauseGame()
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

	public void RestartGame()
	{
		Application.LoadLevel("FattyGame");
	}

	public void ReturnMenu()
	{
		Application.LoadLevel("Menu");
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
		if(difficulty < 10)
		{
			if(eatenCount== 10 - diffScale)
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
