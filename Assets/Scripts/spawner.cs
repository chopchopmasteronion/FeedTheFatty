using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	public GameObject food;
	public float spawnTime;
	private float timer;

	public GameObject topClone; //top clone of our instantiated prefab food
	public GameObject bottomClone; //bottom clone of our instantiated prefab food
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//update the timer with real time
		timer +=Time.deltaTime;
		gameScript gameDiff = (gameScript)GameObject.Find("Main Camera").GetComponent(typeof (gameScript));
		//spawn when spawntime less than timer
		if(spawnTime < timer)
			{
			//on difficulty 3 we need to instantiate food on bottom and top
				int diff = gameDiff.getDifficulty();
				if( 3 <= diff)
				{
				//instantiate food on the top
				topClone = Instantiate (food, new Vector3(10f, 3f, -.5f), Quaternion.identity) as GameObject;
				topClone.tag = "Top"; //tag the food top so we can identify it later
				}
			//always instantiate food on the bottom conveyor belt
			bottomClone = Instantiate (food, new Vector3(-10f, -3f, -.5f), Quaternion.identity) as GameObject;
			bottomClone.tag = "Bottom"; 
			timer=0; //reset timer
			}
	}
}
