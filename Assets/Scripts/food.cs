using UnityEngine;
using System.Collections;

public class food : MonoBehaviour {
	int type = 1; //0 is fatty 1 is healthy 
	int direction; //-1 is left 1 is right
	int touched = 0; //0 is not touched, 1 is touched
	int conveyer; //-1 is bottom 1 is top
	public int speed; //speed of the object moving accross the conveyer belt
	public int launchSpeed; //speed when launched
	public Material materialFatty;

	// Use this for initialization
	void Start () {
		//check if fatty
		if (7 > Random.Range (0, 9)) 
		{
			type = 0;
			this.renderer.material = materialFatty;
		}
		//find which conveyer is on		
		if (0 > transform.position.y)
		{
			conveyer = 1;
		}
		else 
		{
			conveyer = -1;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (touched == 0) 
		{
			Ride ();
		}
		else 
		{
			Launch();
		}
	}

	//Touch is called from the control class
	void Touch()
	{
		touched = 1;
	}

	//Ride provides a means of transport for food
	void Ride()
	{
		//set speed based on difficulty
		if (10 < transform.position.x) 
		{
			Destroy(this.gameObject);
		}
		transform.Translate (Vector3.right * (speed * Time.deltaTime));
	}

	//Launch sends the food towards the center
	void Launch()
	{
		if (0 < transform.position.y) 
		{
			Destroy(this.gameObject);
		}
		transform.Translate (Vector3.up * (launchSpeed * Time.deltaTime));
	}

	//returns the type of food
	public int getType()
	{
		return type;
	}
}
