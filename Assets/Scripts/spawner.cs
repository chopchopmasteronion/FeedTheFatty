using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	public GameObject food;
	public float spawnTime;
	private float timer;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//update the timer with real time
		timer +=Time.deltaTime;
		//spawn when spawntime less than timer
		if(spawnTime < timer)
			{
			Instantiate (food, new Vector3(-10f, -3f, -.5f), Quaternion.identity);
			timer=0; //reset timer
			}
	}
}
