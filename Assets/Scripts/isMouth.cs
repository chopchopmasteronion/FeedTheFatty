using UnityEngine;
using System.Collections;

public class isMouth : MonoBehaviour {
	public food food;
	public static int score = 0; //score for the game
	public isMouth mouth;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "food(Clone)")
		{
			Destroy(other.gameObject);
			updateScoreBy(+1);
		}

	}

	//function that updates the score. public so other classes can call it
	public void updateScoreBy(int deltaScore) 
	{
		isMouth.score += deltaScore;
	}
	
	//create the gui for the game
	void OnGUI() {
		GUIStyle style = new GUIStyle();
		style.fontSize = 10;
		GUI.Label(new Rect(0,0,100,20), "Score:"+isMouth.score, style );	
	}
}
