using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public gameScript game;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();
		if(Input.GetMouseButtonDown(0)) 
		{
			//Touch logic
			if(Physics.Raycast(ray, out hit)) 
			{
				//Touch food logic
				if("food(Clone)" == hit.collider.name)
				{
					GameObject food = hit.collider.gameObject;
					food.SendMessage("Touch");
				}
				//Pause game logic
				if("pause_button" == hit.collider.name)
				{
					game.SendMessage("PauseGame");
				}
			}

		}
	}
}
