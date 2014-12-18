using UnityEngine;
using System.Collections;

public class food : MonoBehaviour {
	int type = 1; //0 is fatty 1 is healthy 
	int direction; //-1 is left 1 is right
	int speed; //speed of the object moving accross the conveyer belt
	public Material materialFatty;

	// Use this for initialization
	void Start () {
		//check if fatty
		if (7 > Random.Range (0, 9)) {
			type = 0;
			this.renderer.material = materialFatty;
				}
	}
	
	// Update is called once per frame
	void Update () {
		//set speed based on difficulty
		speed = 3;
	if (4.7 < transform.position.x) 
		{
			Destroy(this.gameObject);
		}
		transform.Translate (Vector3.right * (speed * Time.deltaTime));
	}
}
