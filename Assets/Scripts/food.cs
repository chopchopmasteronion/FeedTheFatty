﻿using UnityEngine;
using System.Collections;

public class food : MonoBehaviour {
	public int type; //0 is fatty 1 is healthy 
	int direction; //-1 is left 1 is right
	int touched = 0; //0 is not touched, 1 is touched
	int weight;
	public bool bigFood;
	public int speed; //speed of the object moving accross the conveyer belt
	public int launchSpeed; //speed when launched
	public Sprite[] fatFoods;
	public AudioClip splat;


	// Use this for initialization
	void Start () {
		type = 1;
		weight = 0;
		SetWeight(0);
		//check if fatty
		if (7 > Random.Range (0, 9)) //set food as healthy
		{
			type = 0;
			SetWeight(1);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (touched == 0) 
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
		else 
		{
			//if tag is top then launch down
			if(this.gameObject.tag == "Top")
			{
				Launch(1);
			}
			else
			{
				//if tag is not top then launch up
				Launch (0);
			}
		}
	}

	//Touch is called from the control class
	void Touch()
	{
		touched = 1;
	}

	//Ride provides a means of transport for food
	void Ride(int type)
	{
		gameScript gameDiff = (gameScript)GameObject.Find("Main Camera").GetComponent(typeof (gameScript));
		//move bottom foods to the right
		if(type == 0)
		{
			//set speed based on difficulty
			if (10 < transform.position.x) 
			{
				Destroy(this.gameObject);
			}
			transform.Translate (Vector3.right * ((gameDiff.getDifficulty() + speed) * Time.deltaTime));
			
		}
		//move top foods to the left
		if(type == 1)
		{
			//set speed based on difficulty
			if (-10 > transform.position.x) 
			{
				Destroy(this.gameObject);
			}
			transform.Translate (Vector3.left * ((gameDiff.getDifficulty() + speed) * Time.deltaTime));
		}
	}

	//Launch sends the food towards the center
	void Launch(int type)
	{
		//tag is bottom so we need to launch up
		if(type == 0)
		{
			if (0 < transform.position.y) 
			{
				this.destroy();
				
			}
			transform.Translate(Vector3.up * (launchSpeed * Time.deltaTime), Space.World);
			transform.Rotate(0, 0, 360 * Time.deltaTime);
		}
		//tag is top so we need to launch down
		if(type == 1)
		{
			if (0 > transform.position.y) 
			{
				this.destroy();
			}
			transform.Translate (Vector3.down * (launchSpeed * Time.deltaTime), Space.World);
			transform.Rotate(0, 0, -360 * Time.deltaTime);
		}
	}
	
	void destroy()
	{
		audio.PlayOneShot(splat);
		Destroy(this.gameObject);
	}

	//returns the type of food
	public int getType()
	{
		return type;
	}
	
	public int getWeight()
	{
		return weight;
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
