using UnityEngine;
using System.Collections;

public class isMouth : MonoBehaviour {
	public isMouth mouth;
	public gameScript game;
	public int speed;
	public float moveTime;
	int direction;
	public GameObject crumbsplosion;
	// Use this for initialization
	void Start () 
{
	moveTime=0;
	}
	
	// Update is called once per frame
	void Update () {
		gameScript gameDiff = (gameScript)GameObject.Find("Main Camera").GetComponent(typeof (gameScript));
		if(gameDiff.difficulty > 0)
		{
			sendMove();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "food(Clone)")
		{
			food eat = (food)other.gameObject.GetComponent(typeof(food));
			if(0 == eat.getType())
			{
				game.updateScore(eat.getWeight());
			}
			else
			{
				game.ateHealthy();
			}
			Destroy(other.gameObject);
			Instantiate(crumbsplosion, transform.position, Quaternion.identity);

		}
	}
	void move(int direction)
	{
		switch (direction)
		{
		case 0: 
			transform.Translate (Vector3.left * (speed * Time.deltaTime));
			break;
		case 1:	
			transform.Translate (Vector3.right * (speed * Time.deltaTime));
			break;
		}
	}
	
	void sendMove()
	{
		if(moveTime > 0 && (transform.position.x > -7 && transform.position.x < 7))	
		{
			move (direction);
			moveTime -= Time.deltaTime;
		}
		else if (transform.position.x < -7)
		{
			move (1);
			direction = 1;
		}
		else if (transform.position.x > 7)
		{
			move (0);
			direction = 0;
		}
		else 
		{
			moveTime = Random.Range(1,10);
			direction = Random.Range(0,2);	
		}
	}
}
