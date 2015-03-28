using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {
	persistence ps;
	public Text hs;
	public GameObject food;
	public GameObject topClone; //top clone of our instantiated prefab food
	public GameObject bottomClone; //bottom clone of our instantiated prefab food
	private float timer;
	// Use this for initialization
	void Start () {
	ps = new persistence();
	hs.text = ps.writeScore();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(.5 < timer)
		{
			topClone = Instantiate (food, new Vector3(10f, -3.1f, -.5f), Quaternion.identity) as GameObject;
			topClone.tag = "Top"; //tag the food top so we can identify it later
			bottomClone = Instantiate (food, new Vector3(-10f, -4.1f, -.5f), Quaternion.identity) as GameObject;
			bottomClone.tag = "Bottom"; 
			bottomClone = Instantiate (food, new Vector3(-10f, -2.1f, -.5f), Quaternion.identity) as GameObject;
			bottomClone.tag = "Bottom"; 
			topClone = Instantiate (food, new Vector3(10f, -1.1f, -.5f), Quaternion.identity) as GameObject;
			topClone.tag = "Top"; //tag the food top so we can identify it later
			bottomClone = Instantiate (food, new Vector3(-10f, -0.1f, -.5f), Quaternion.identity) as GameObject;
			bottomClone.tag = "Bottom"; 
			topClone = Instantiate (food, new Vector3(10f, 1.1f, -.5f), Quaternion.identity) as GameObject;
			topClone.tag = "Top"; //tag the food top so we can identify it later
			bottomClone = Instantiate (food, new Vector3(-10f, 2.1f, -.5f), Quaternion.identity) as GameObject;
			bottomClone.tag = "Bottom"; 
			topClone = Instantiate (food, new Vector3(10f, 3.1f, -.5f), Quaternion.identity) as GameObject;
			topClone.tag = "Top"; //tag the food top so we can identify it later
			bottomClone = Instantiate (food, new Vector3(-10f, 4.1f, -.5f), Quaternion.identity) as GameObject;
			bottomClone.tag = "Bottom"; 

			timer = 0;
		}
		if (Input.anyKeyDown) {
			Application.LoadLevel("Menu");
		}
	}
	public int getDifficulty()
	{
		return 3;
	}	
}
