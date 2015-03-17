using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

	public AudioClip pop;
	public gameScript game;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();
		if(Time.timeScale==1){
		if(Input.GetMouseButtonDown(0)) 
		{
			//Touch logic
			if(Physics.Raycast(ray, out hit)) 
			{
				//Touch food logic
				if("food(Clone)" == hit.collider.name)
				{
					GameObject food = hit.collider.gameObject;
					audio.PlayOneShot(pop);
					food.SendMessage("Touch");
				}
			}
			}
		}
	}
}
