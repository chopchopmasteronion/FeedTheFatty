using UnityEngine;
using System.Collections;

public class isMouth : MonoBehaviour {
	public isMouth mouth;
	public gameScript game;
	private GameObject eatMe;
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
			food eat = (food)other.gameObject.GetComponent(typeof(food));
			if(0 == eat.getType())
			{
				game.updateScore();
			}
			else
			{
				game.ateHealthy();
			}
			Destroy(other.gameObject);

		}
	}
}
