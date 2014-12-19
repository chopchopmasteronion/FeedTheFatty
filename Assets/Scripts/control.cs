using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();
		GameObject food;
		if(Input.GetMouseButton(0)) {
			if(Physics.Raycast(ray, out hit)) {
				//print(hit.collider.name);
				if("food(Clone)" == hit.collider.name){
					//print ("Touching food");
					food = hit.collider.gameObject;
					food.SendMessage("Touch");
				}
			}
		}
	}
}
