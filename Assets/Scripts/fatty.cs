using UnityEngine;
using System.Collections;

public class fatty : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{	


	}
	
	

	public void grow()
	{
		transform.localScale += new Vector3(.01f, 0, 0);
	}

}
