using UnityEngine;
using System.Collections;

public class isMouth : MonoBehaviour {
	public isMouth mouth;
	public gameScript game;
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
			game.updateScore();
		}
	}
}
