using UnityEngine;
using System.Collections;

public class menuFood : MonoBehaviour {

	int type = 1; //0 is fatty 1 is healthy 
	int direction; //-1 is left 1 is right
	int weight;
	public int speed; //speed of the object moving accross the conveyer belt
	public Sprite[] fatFoods;
	
	
	// Use this for initialization
	void Start () {
		weight = 0;
		SetWeight(0);
		//check if fatty
		if (7 > Random.Range (0, 9)) 
		{
			type = 0;
			SetWeight(1);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if the tag is top then ride to the right
		if(this.gameObject.tag == "Top")
		{
			Ride (1);
		}
		else
		{
			//if tag is not top ride to the right
			Ride (0);
		}
	}

	
	//Ride provides a means of transport for food
	void Ride(int type)
	{
		//move bottom foods to the right
		if(type == 0)
		{
			//set speed based on difficulty
			if (10 < transform.position.x) 
			{
				Destroy(this.gameObject);
			}
			transform.Translate (Vector3.right * 6 * Time.deltaTime);
			
		}
		//move top foods to the left
		if(type == 1)
		{
			//set speed based on difficulty
			if (-10 > transform.position.x) 
			{
				Destroy(this.gameObject);
			}
			transform.Translate (Vector3.left * 6 * Time.deltaTime);
		}
	}

	void SetWeight(int choice)
	{
		if(choice == 1)
		{
			
			weight = (Random.Range(1,8));
			switch (weight)
			{
			case 1:
				GetComponent<SpriteRenderer>().sprite= fatFoods[1];
				break;
			case 2:
				GetComponent<SpriteRenderer>().sprite= fatFoods[0];
				break;
			case 3:
				GetComponent<SpriteRenderer>().sprite= fatFoods[4];
				break;
			case 4:
				GetComponent<SpriteRenderer>().sprite= fatFoods[3];
				break;
			case 5:
				GetComponent<SpriteRenderer>().sprite= fatFoods[2];
				break;
			case 6:
				GetComponent<SpriteRenderer>().sprite= fatFoods[5];
				break;
			case 7:
				GetComponent<SpriteRenderer>().sprite= fatFoods[6];
				break;
			case 8:
				GetComponent<SpriteRenderer>().sprite= fatFoods[7];
				break;
			}
		} else {
			
			weight = (Random.Range(9,12));
			switch (weight)
			{
			case 9:
				GetComponent<SpriteRenderer>().sprite= fatFoods[10];
				break;
			case 10:
				GetComponent<SpriteRenderer>().sprite= fatFoods[11];
				break;
			case 11:
				GetComponent<SpriteRenderer>().sprite= fatFoods[8];
				break;
			case 12:
				GetComponent<SpriteRenderer>().sprite= fatFoods[9];
				break;
			}
		}
		
		
	}
}
